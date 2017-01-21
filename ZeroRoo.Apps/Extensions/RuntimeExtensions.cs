using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using ZeroRoo.Apps.Abstractions;
using System.IO;
using ZeroRoo.Events;
using System.Reflection;

namespace ZeroRoo.Apps
{
    public static class Runtimeapps
    {
        public static IRuntimeBuilder UseApps(this IRuntimeBuilder builder)
        {
            IServiceProvider provider = builder.Services.BuildServiceProvider();
            var appManager = provider.GetRequiredService<IAppManager>();
            var hostingEnvironment = provider.GetRequiredService<IRuntimeEnviroment>();
            var loggerFactory = provider.GetRequiredService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger("Default");

            var availableapps = appManager.GetApps();
            foreach (var app in availableapps)
            {
                var contentPath = Path.Combine(app.AppFileInfo.PhysicalPath, "Content");
                if (Directory.Exists(contentPath))
                {
                    
                }
            }

            using (logger.BeginScope("Loading apps"))
            {
                //Parallel.ForEach(availableapps, new ParallelOptions { MaxDegreeOfParallelism = 4 }, ae =>
                //{
                foreach (var ae in availableapps)
                {
                    try
                    {
                        var appEntry = appManager.LoadAppAsync(ae).Result;

                        if (!appEntry.IsError)
                        {
                            foreach (var item in appEntry.ExportedTypes.Where(h => typeof(IStartup).IsAssignableFrom(h)))
                            {
                                builder.Services.AddScoped(typeof(IStartup), item);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        logger.LogCritical("Could not load an app", ae, e);
                    }
                }
                //});
            }

            var secProvider = builder.Services.BuildServiceProvider();

            foreach(var startup in secProvider.GetServices<IStartup>())
            {
                startup.ConfigureServices(builder.Services);
                startup.Configure(builder, provider);
            }

            return builder;
        }

        private static bool IsStartup(Type type)
        {
            return typeof(IStartup).IsAssignableFrom(type);
        }

        public static IRuntimeBuilder UseEventBus(this IRuntimeBuilder builder)
        {
            var twoServices = builder.Services;

            twoServices.AddScoped<IEventBus, DefaultZeroEventBus>();
            twoServices.AddSingleton<IEventBusState, EventBusState>();

            var applicationServiceDescriptors = twoServices.Where(x => x.Lifetime == ServiceLifetime.Singleton);

            var eventHandlers = twoServices
                .Union(applicationServiceDescriptors)
                .Select(x => x.ImplementationType)
                .Distinct()
                .Where(t => t != null && typeof(IEventHandler).IsAssignableFrom(t) && t.GetTypeInfo().IsClass)
                .ToArray();

            foreach (var handlerClass in eventHandlers)
            {
                // Register dynamic proxies to intercept direct calls if an IEventHandler is resolved, dispatching the call to
                // the event bus.

                foreach (var i in handlerClass.GetInterfaces().Where(t => t != typeof(IEventHandler) && typeof(IEventHandler).IsAssignableFrom(t)))
                {
                    twoServices.AddScoped(i, serviceProvider =>
                    {
                        var proxy = DefaultZeroEventBus.CreateProxy(i);
                        proxy.EventBus = serviceProvider.GetService<IEventBus>();
                        return proxy;
                    });
                }
            }

            var shellServiceProvider = twoServices.BuildServiceProvider();

            using (var scope = shellServiceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var eventBusState = scope.ServiceProvider.GetService<IEventBusState>();

                // Register any IEventHandler method in the event bus
                foreach (var handlerClass in eventHandlers)
                {
                    foreach (var handlerInterface in handlerClass.GetInterfaces().Where(x => typeof(IEventHandler).IsAssignableFrom(x) && typeof(IEventHandler) != x))
                    {
                        foreach (var interfaceMethod in handlerInterface.GetMethods())
                        {
                            //var classMethod = handlerClass.GetMethods().Where(x => x.Name == interfaceMethod.Name && x.GetParameters().Length == interfaceMethod.GetParameters().Length).FirstOrDefault();
                            Func<IServiceProvider, IDictionary<string, object>, Task> d = (sp, parameters) => DefaultZeroEventBus.Invoke(sp, parameters, interfaceMethod, handlerClass);
                            var messageName = $"{handlerInterface.Name}.{interfaceMethod.Name}";
                            var className = handlerClass.FullName;
                            eventBusState.Add(messageName, d);
                        }
                    }
                }
            }
            return builder;
        }
    }
}
