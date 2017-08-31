using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo;
using ZeroRoo.Apps.Services;
using ZeroRoo.DefaultApp.Activities;
using ZeroRoo.DefaultApp.Services;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.DefaultApp
{
    public class Startup: StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.AddScoped<IAppService, ApplicationExit>();
            services.AddScoped<IAppService, GetAppMenuItems>();
            services.AddScoped<IAppService, GetDesktopFiles>();
            services.AddScoped<IAppService, GetVersion>();
            services.AddScoped<IAppService, MessageAlert>();
            services.AddScoped<IAppService, Open>();
            services.AddScoped<IAppService, ActivityTitleChange>();

            services.AddScoped<INavigationProvider, Menu>();
            services.AddScoped<IActivity, ApplicationExitActivity>();
        }

        public override void Configure(IServiceCollection runtimeBuilder, IServiceProvider serviceProvider)
        {
            base.Configure(runtimeBuilder, serviceProvider);
        }
    }
}
