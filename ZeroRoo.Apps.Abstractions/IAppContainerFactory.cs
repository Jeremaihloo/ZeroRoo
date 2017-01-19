using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Abstractions
{
    public interface IAppContainerFactory
    {
        IServiceProvider CreateContainer(IServiceProvider provider);
    }
}
