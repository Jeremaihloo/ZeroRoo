using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Configuration
{
    public interface IConfigProvider
    {
        T GetConfig<T>(string absPath);
    }
}
