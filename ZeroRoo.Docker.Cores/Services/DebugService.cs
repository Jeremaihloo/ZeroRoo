using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Docker.Cores.Services
{
    public class DebugService: IAppService
    {
        private IAppServiceServer appServiceServer;

        public DebugService(IAppServiceServer appServiceServer)
        {
            this.appServiceServer = appServiceServer;
        }

        public void AddProxy(string src, string target)
        {
            this.appServiceServer.AddProxy(src, target);
        }
    }
}
