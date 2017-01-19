using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public class DefaultStartup: StartupBase
    {
        private IConfiguration CoreConfiguration { get; }

        public DefaultStartup(IRuntimeEnviroment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appcore.json", optional: true, reloadOnChange: true);

            CoreConfiguration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public override void ConfigureServices(IServiceCollection services)
        {
            // Add CoreConfiguration
            services.AddSingleton<IConfiguration>(CoreConfiguration);
        }

        // This method gets called by the runtime. Use this method to configure the application.
        public override void Configure(IRuntimeBuilder runtimeBuilder, IServiceProvider serviceProvider)
        {
            
        }
    }
}
