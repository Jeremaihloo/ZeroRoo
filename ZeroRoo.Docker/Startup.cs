using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo;
using Microsoft.Extensions.DependencyInjection;
using ZeroRoo.Apps;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Manifests;
using ZeroRoo.Docker.Shapes;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker
{
    public class Startup: StartupBase
    {
        private IConfiguration CoreConfiguration { get; }

        public Startup(IRuntimeEnviroment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appcore.json", optional: true, reloadOnChange: true);

            CoreConfiguration = builder.Build();
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.AddLogging();
            services.AddOptions();
            services.AddSingleton<IAppContainerFactory, AppContainerFactory>();

            services.AddAppManagerHost("Apps", "Apps");
            services.AddManifestDefinition("App.txt", "app");
            services.AddAppLocation("Apps"); 
            services.AddAppManager();

            services.AddNavigation();
            services.AddDockerShape();
        }

        public override void Configure(IRuntimeBuilder runtimeBuilder, IServiceProvider serviceProvider)
        {
            base.Configure(runtimeBuilder, serviceProvider);

            runtimeBuilder.UseApps();

            runtimeBuilder.UseDockerNavigation();
        }
    }
}
