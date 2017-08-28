using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection UseStartup(this IServiceCollection services, IStartup startup)
        {
            startup.ConfigureServices(services);

            startup.Configure(services.BuildServiceProvider());

            return services;
        }

        public static IServiceCollection AddEnviroment(this IServiceCollection services, IRuntimeEnviroment env)
        {
            services.AddSingleton(env);
            return services;
        }
    }
}
