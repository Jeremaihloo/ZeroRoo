using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.JsServices;
using ZeroRoo.Docker.JsServices.Structs;

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
        
        public DesktopFileButton[] GetDesktopFiles()
        {
            var o = this.DesktopFileService.GetDesktopFiles().ToArray();
            return o;
        }

        public DockBarButton[] GetDockBarButtons()
        {
            return this.DesktopMenuService.GetButtons().ToArray();
        }

        public void Open(string openUri)
        {
            // app://Simple1:MainActivity
            // file://C://Users/jj/test.txt
            // http://
            // https://

        }

        public void OpenApp(string menuName)
        {

        }
    }
}
