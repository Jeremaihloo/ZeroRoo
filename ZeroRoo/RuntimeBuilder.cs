using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Logging;

namespace ZeroRoo
{
    public class RuntimeBuilder : IRuntimeBuilder
    {
        public IRuntimeEnviroment Enviroment { get; set; }

        public IServiceCollection Services { get; set; }

        public RuntimeBuilder()
        {
            this.Services = new ServiceCollection();
            this.Enviroment = new ZeroRuntimeEnviroment();
        }

        public IRuntime Build()
        {
            return new ZeroRuntime() { Services = this.Services };
        }
    }
}
