using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public class ZeroRuntime : IRuntime
    {
        public IServiceCollection Services { get; set; }

        public IServiceProvider Provider { get { return Services.BuildServiceProvider(); } }

        public void Run()
        {
            
        }
    }
}
