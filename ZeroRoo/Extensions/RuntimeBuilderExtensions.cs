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
        public static IServiceCollection UseStartup(this IServiceCollection builder, IStartup startup)
        {
            startup.ConfigureServices(builder);

            startup.Configure(builder, builder.BuildServiceProvider());

            return builder;
        }

        public static IServiceCollection AddEnviroment(this IServiceCollection builder, IRuntimeEnviroment env)
        {
            builder.AddSingleton(env);
            return builder;
        }
    }
}
