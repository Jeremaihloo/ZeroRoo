using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public class AppSystemConfigs
    {
        public Dictionary<string, object> Pairs { get; private set; }

        public AppSystemConfigs()
        {
            this.Pairs = new Dictionary<string, object>();
        }

        public void Set(string key, object val)
        {
            this.Pairs[key] = val;
        }

        public object Get(string key)
        {
            return this.Pairs[key];
        }
    }
}
