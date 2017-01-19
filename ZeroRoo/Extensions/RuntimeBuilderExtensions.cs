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
        public static IRuntimeBuilder UseStartup(this IRuntimeBuilder builder, IStartup startup)
        {
            startup.ConfigureServices(builder.Services);

            startup.Configure(builder, builder.Services.BuildServiceProvider());

            return builder;
        }

        public static IRuntimeBuilder UseEnviroment(this IRuntimeBuilder builder, IRuntimeEnviroment env)
        {
            builder.Enviroment = env;
            builder.Services.AddSingleton(env);
            return builder;
        }
    }
}
