using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.JsServices;
using ZeroRoo.Docker.JsServices.Structs;

namespace ZeroRoo.Docker
{
    public class ZeroRooJsBradge
    {
        public DesktopMenuService DesktopMenuService { get; set; }
        public DesktopNotifyService DesktopNotifyService { get; set; }
        public DesktopFileService DesktopFileService { get; set; }

        public ZeroRooJsBradge(IEnumerable<IAppService> appServices)
        {
            
        }
    }
}
