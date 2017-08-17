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
        public DesktopMenuService DesktopMenuService { get; set; }
        public DesktopNotifyService DesktopNotifyService { get; set; }
        public DesktopFileService DesktopFileService { get; set; }

        public ZeroRooJsBradge(DesktopFileService desktopFileService, 
                                DesktopMenuService desktopMenuService, 
                                DesktopNotifyService desktopNotifyService)
        {
            this.DesktopFileService = desktopFileService;
            this.DesktopMenuService = desktopMenuService;
            this.DesktopNotifyService = desktopNotifyService;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public Shapes.MenuItemButton GetDesktopMenuItems()
        {
            return this.DesktopMenuService.GetButtons().ToArray()[0];
        }
    }
}
