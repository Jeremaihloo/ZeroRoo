using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps
{
    public interface IEnviroment
    {
        void Set<T>(T model);

        void Set(string key, object value);

        T Get<T>();

        object Get(string key);

    }
}
