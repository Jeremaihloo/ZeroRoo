using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker.Cores.Services
{
    public class Open : IAppService
    {
        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            route.SendMessage(msg);
        }
    }
}
