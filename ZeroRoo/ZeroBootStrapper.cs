using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public class ZeroBootStrapper
    {
        public static IServiceCollection Services { get; set; }

        public static void Run()
        {
            Services = new ServiceCollection();
        }
    }
}
