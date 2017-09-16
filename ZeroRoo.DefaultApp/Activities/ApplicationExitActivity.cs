using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Net;
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.DefaultApp.Activities
{
    public class ApplicationExitActivity : BaseActivity
    {
        public ApplicationExitActivity()
        {
            this.Title = "退出系统";
        }

        public override void OnView(HttpListenerRequest req, HttpListenerResponse res)
        {
            base.OnView(req, res);
        }
    }
}
