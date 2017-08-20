using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ZeroRoo.BackgroundTasks
{
    public class BackgroundTaskService : IBackgroundTaskService, IDisposable
    {
        private static TimeSpan DontStart = TimeSpan.FromMilliseconds(-1);
        private static TimeSpan StartNow = TimeSpan.FromMilliseconds(0);

        private readonly Dictionary<string, IEnumerable<IBackgroundTask>> _tasks;
        private readonly Dictionary<IBackgroundTask, BackgroundTaskState> _states;
        private readonly Dictionary<string, Timer> _timers;
        private readonly Dictionary<string, TimeSpan> _periods;

        private IServiceCollection services;

        public BackgroundTaskService(
            IEnumerable<IBackgroundTask> tasks,
            ILogger<BackgroundTaskService> logger,
            IServiceCollection services)
        {
            _tasks = tasks.GroupBy(GetGroupName).ToDictionary(x => x.Key, x => x.Select(i => i));
            _states = tasks.ToDictionary(x => x, x => BackgroundTaskState.Idle);
            _timers = _tasks.Keys.ToDictionary(x => x, x => new Timer(DoWorkAsync, x, Timeout.Infinite, Timeout.Infinite));
            _periods = _tasks.Keys.ToDictionary(x => x, x => TimeSpan.FromMinutes(1));
            Logger = logger;

            this.services = services;
        }

        public ILogger Logger { get; set; }

        public void Activate()
        {
            foreach (var group in _timers.Keys)
            {
                var timer = _timers[group];
                var period = _periods[group];
                timer.Change(StartNow, period);
            }
        }

        // NB: Async void should be avoided; it should only be used for event handlers.Timer.Elapsed is an event handler.So, it's not necessarily wrong here.
        // c.f. http://stackoverflow.com/questions/25007670/using-async-await-inside-the-timer-elapsed-event-handler-within-a-windows-servic
        private async void DoWorkAsync(object group)
        {
            var groupName = group as string ?? "";

            foreach (var task in _tasks[groupName])
            {
                var taskName = task.GetType().FullName;

                var provider = services.BuildServiceProvider();

                try
                {
                    if (_states[task] == BackgroundTaskState.Stopped)
                    {
                        return;
                    }

                    lock (_states)
                    {
                        // Ensure Terminate() was not called before
                        if (_states[task] == BackgroundTaskState.Stopped)
                        {
                            return;
                        }

                        _states[task] = BackgroundTaskState.Running;
                    }

                    if (Logger.IsEnabled(LogLevel.Information))
                    {
                        Logger.LogInformation("Start processing background task \"{0}\".", taskName);
                    }

                    await task.DoWorkAsync(provider, CancellationToken.None);

                    if (Logger.IsEnabled(LogLevel.Information))
                    {
                        Logger.LogInformation("Finished processing background task \"{0}\".", taskName);
                    }
                }
                catch (Exception ex)
                {
                    if (Logger.IsEnabled(LogLevel.Error))
                    {
                        Logger.LogError($"Error while processing background task \"{taskName}\": {ex.Message}");
                    }
                }
                finally
                {
                    lock (_states)
                    {
                        // Ensure Terminate() was not called during the task
                        if (_states[task] != BackgroundTaskState.Stopped)
                        {
                            _states[task] = BackgroundTaskState.Idle;
                        }
                    }
                }
            }
        }

        public void Terminate()
        {
            lock (_states)
            {
                foreach (var task in _states.Keys)
                {
                    _states[task] = BackgroundTaskState.Stopped;
                }
            }
        }

        private string GetGroupName(IBackgroundTask task)
        {
            var attributes = task.GetType().GetTypeInfo().GetCustomAttributes<BackgroundTaskAttribute>().ToList();

            if (attributes.Count == 0)
            {
                return "";
            }

            return attributes.First().Group ?? "";
        }

        public IDictionary<IBackgroundTask, BackgroundTaskState> GetTasks()
        {
            return _states;
        }

        public void SetDelay(string group, TimeSpan period)
        {
            var groupName = group ?? "";

            _periods[groupName] = period;
            _timers[groupName].Change(DontStart, period);
        }

        public void Dispose()
        {
            foreach(var timer in _timers.Values)
            {
                timer.Dispose();
            }
        }
    }
}
