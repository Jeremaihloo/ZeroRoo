using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ZeroRoo.Apps.Laundry
{
    public class Startup: StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
        }

        public override void Configure(IRuntimeBuilder runtimeBuilder, IServiceProvider serviceProvider)
        {
            base.Configure(runtimeBuilder, serviceProvider);
        }
    }
}
