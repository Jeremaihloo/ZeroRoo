using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    public interface IAppServiceServer
    {
        void Start();

        void Stop();

        void AddProxy(string src, string target);
    }
}
