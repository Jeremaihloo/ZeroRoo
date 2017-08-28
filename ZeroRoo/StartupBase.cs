using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ZeroRoo
{
    public abstract class StartupBase : IStartup
    {
        public virtual void Configure(IServiceCollection runtimeBuilder, IServiceProvider serviceProvider)
        {
            
        }

        public virtual void ConfigureServices(IServiceCollection services)
        {
            
        }
    }
}
