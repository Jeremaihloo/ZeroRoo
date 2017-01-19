using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q;
using ZeroRoo.Docker.Shapes;

namespace ZeroRoo.Docker.Core
{
    public static class RuntimeExtentions
    {
        public static IRuntime RunForm<T>(this IRuntime runtime)
        {
            var provider = runtime.Services.BuildServiceProvider();
            var dash = provider.GetRequiredService<T>() as Form;
            Application.Run(dash);
            return runtime;
        }
    }
}
