using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.JsServices;

namespace ZeroRoo.Docker
{
    public struct JsObject
    {
        public string Value;
    }

    public class SubC
    {
        public int A;
        public string B;
    }

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

        public string GetDesktopMenuItems()
        {
            var o = this.DesktopMenuService.GetButtons().ToArray();
            return Newtonsoft.Json.JsonConvert.SerializeObject(o);
        }

        public SubC[] ObjectArray(string name)
        {
            return new[]
            {
                new SubC(){ A=1, B="lujiejie" }
            };
        }
    }
}
