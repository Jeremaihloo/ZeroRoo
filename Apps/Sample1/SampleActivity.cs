using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;
using ZeroRoo.Apps.Services;
using WebSocketSharp.Net;

namespace Sample1
{
    public partial class SampleActivity : BaseActivity
    {
        public SampleActivity()
        {
            this.Title = "实例";
            this.RoutePattern = "sample1";
        }

        public override void OnView(HttpListenerRequest req, HttpListenerResponse res)
        {
            throw new NotImplementedException();
        }
    }
}
