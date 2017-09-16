using System;
using WebSocketSharp.Net;
using ZeroRoo.Apps.Services;
namespace ZeroRoo.Apps.LaundryAgent
{
    public class LaundryAgentActivity : BaseActivity
    {
        public LaundryAgentActivity()
        {
            this.Title = "代卖衣服";
            this.RoutePattern = ".*?LaundryAgent.*?";
        }

        public override void OnView(HttpListenerRequest req, HttpListenerResponse res)
        {
            WriteViewContent(res, "/Apps/ZeroRoo.Apps.LaundryAgent/index.html");
        }
    }
}
