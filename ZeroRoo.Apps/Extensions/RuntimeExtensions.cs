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
                Parallel.ForEach(availableapps, new ParallelOptions { MaxDegreeOfParallelism = 4 }, ae =>
                {
                    try
                    {
                        var appEntry = appManager.LoadAppAsync(ae).Result;

                        if (!appEntry.IsError)
                        {
                            IStartup startup = null;
                            foreach (var item in appEntry.ExportedTypes)
                            {
                                if (IsStartup(item))
                                {
                                    try
                                    {
                                        startup = (IStartup)Activator.CreateInstance(item);
                                    }
                                    catch(Exception ex)
                                    {
                                        logger.LogCritical("Startup Create Error", ex.Message);
                                    }
                                }
                            }
                            startup.ConfigureServices(builder.Services);
                            startup.Configure(builder, builder.Services.BuildServiceProvider());
                        }
                    }
                    catch (Exception e)
                    {
                        logger.LogCritical("Could not load an app", ae, e);
                    }
                });
            }

            return builder;
        }

        private static bool IsStartup(Type type)
        {
            return typeof(IStartup).IsAssignableFrom(type);
            //return type.Name == "Startup";
        }
    }
}
