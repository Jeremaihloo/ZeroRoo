using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Docker.Services
{
    
    public class DesktopNotifyService : IAppService
    {
        private IAppServiceServer appServiceServer;

        public DesktopNotifyService(IAppServiceServer appServiceServer)
        {
            this.appServiceServer = appServiceServer;
        }

        public bool MessageAlert(AppServiceMessage msg)
        {
            this.appServiceServer.Broadcast(msg);
            return true;
        }
    }
}
