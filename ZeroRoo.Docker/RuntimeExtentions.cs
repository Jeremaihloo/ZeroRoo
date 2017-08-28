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
        public static IServiceProvider RunForm<T>(this IServiceProvider provider)
        {
            var dash = provider.GetRequiredService<T>() as Form;
            Application.Run(dash);
            return provider;
        }
    }
}
