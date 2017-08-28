using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public static class RuntimeBuilderExtensions
    {
        public static IServiceProvider UseStartup(this IServiceCollection builder, IStartup startup)
        {

            startup.ConfigureServices(builder);

            var provider = builder.BuildServiceProvider();

            startup.Configure(builder, provider);

            builder.AddSingleton<IServiceProvider>(provider);

            return provider;
        }

        public static IServiceCollection AddEnviroment(this IServiceCollection builder, IRuntimeEnviroment env)
        {
            builder.AddSingleton(env);
            return builder;
        }
    }
}
