using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroRoo.Docker.Shapes;

namespace ZeroRoo.Docker.Core
{
    public static class RuntimeExtentions
    {
        public static IServiceCollection RunForm<T>(this IServiceCollection runtime)
        {
            var provider = runtime.BuildServiceProvider();
            var dash = provider.GetRequiredService<T>() as Form;
            Application.Run(dash);
            return runtime;
        }
    }
}
