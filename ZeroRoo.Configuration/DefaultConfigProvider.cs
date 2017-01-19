using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Configuration
{
    public class DefaultConfigProvider : IConfigProvider
    {
        public T GetConfig<T>(string absPath)
        {
            throw new NotImplementedException();
        }
    }
}
