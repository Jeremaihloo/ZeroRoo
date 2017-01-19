using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public interface IRuntimeBuilder
    {
        IServiceCollection Services { get; set; }
        IRuntimeEnviroment Enviroment { get; set; }
        IRuntime Build();
    }
}
