using System;
using Microsoft.Extensions.DependencyInjection;
using ZeroRoo.Docker.Navigation;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Apps.LaundryAgent
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.AddScoped<INavigationProvider, Menu>();
            services.AddScoped<IActivity, LaundryAgentActivity>();
            services.AddScoped<IAppService, LaundryAgent>();
        }

        public override void Configure(IServiceCollection runtimeBuilder, IServiceProvider serviceProvider)
        {
            base.Configure(runtimeBuilder, serviceProvider);
        }
    }
}
