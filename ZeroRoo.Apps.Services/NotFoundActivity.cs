using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Net;

namespace ZeroRoo.Apps.Services
{
    public class NotFoundActivity : BaseActivity
    {
        public NotFoundActivity()
        {
            this.Title = "Activity Not Found !";
            this.RoutePattern = ".*?404\\.html.*?";
        }

        public override void OnView(HttpListenerRequest req, HttpListenerResponse res)
        {
            WriteHtmlContent(res, "<h1>Activity Not Found</h1>");
        }
    }
}
