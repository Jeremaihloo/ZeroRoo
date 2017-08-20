using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Docker.JsServices
{
    public class MainAppService: IAppService
    {
        public Version GetVersion(AppServiceMessage msg)
        {
            return new Version(0, 0, 1);
        }

        public void Open(string openUri)
        {
            // app://Simple1:MainActivity
            // file://C://Users/jj/test.txt
            // http://
            // https://
        }
    }
}
