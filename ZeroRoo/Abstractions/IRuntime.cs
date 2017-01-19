using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public interface IRuntime
    {
        IServiceCollection Services { get; set; }
        void Run();
    }
}
