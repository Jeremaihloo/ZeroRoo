using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.JsServices;

namespace ZeroRoo.Docker
{
    public class ZeroRooJsBradge
    {
        public DesktopMenuService DesktopMenu { get; set; }
        public DesktopNotifyService DesktopNotify { get; set; }
    }
}
