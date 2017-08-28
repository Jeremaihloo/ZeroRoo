using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo;
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.Navigation;

namespace Sample1
{
    public class Startup: StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.AddScoped<INavigationProvider, Menu>();
            services.AddScoped<IActivity, SampleActivity>();
        }

        public override void Configure(IServiceCollection runtimeBuilder, IServiceProvider serviceProvider)
        {
            base.Configure(runtimeBuilder, serviceProvider);
        }
    }
}
