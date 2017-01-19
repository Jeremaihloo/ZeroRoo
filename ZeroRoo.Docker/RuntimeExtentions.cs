using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q;

namespace ZeroRoo.Docker.Core
{
    public static class RuntimeExtentions
    {
        public static IRuntime RunForm<T>(this IRuntime runtime)
        {
            var dash = runtime.Services.BuildServiceProvider().GetRequiredService<T>();

            Application.Run(dash as Form);
            return runtime;
        }
    }
}
