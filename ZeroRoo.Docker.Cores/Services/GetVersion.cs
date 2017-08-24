using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Docker.Cores.Services
{
    public class GetVersion : IAppService
    {
        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            msg.Data = "0.0.1";
            route.SendMessage(msg);
        }
    }
}
