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
using ZeroRoo.FileSystem;
using ZeroRoo.Apps.Services;
using ZeroRoo.DbConfigurations;

namespace ZeroRoo.Docker
{
    public class Startup: StartupBase
    {
        private IConfiguration CoreConfiguration { get; }

        public Startup(IRuntimeEnviroment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appcore.json", optional: true, reloadOnChange: true)
                .AddDatabase("DefaultDb", null);

            CoreConfiguration = builder.Build();
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.AddSingleton<IServiceCollection>(services);

            services.AddLogging();
            services.AddOptions();

            services.AddAppManagerHost("Apps", "Apps");
            services.AddManifestDefinition("App.txt", "app");
            services.AddAppLocation("Apps"); 
            services.AddAppManager();

            services.AddSingleton<IAppContainerFactory, AppContainerFactory>();
            
            services.AddNavigation();
            services.AddDockerShape();
            
            


            services.AddDefaultFileSystem();

            services.AddAppsServices();

            services.AddApps();

        }

        public override void Configure(IServiceCollection runtimeBuilder, IServiceProvider serviceProvider)
        {
            base.Configure(runtimeBuilder, serviceProvider);


            serviceProvider.UseAppsServices();

        }
    }
}
