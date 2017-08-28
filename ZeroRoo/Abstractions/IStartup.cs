using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public interface IStartup
    {
        void ConfigureServices(IServiceCollection services);
        void Configure(IServiceCollection services, IServiceProvider serviceProvider);
    }
}
