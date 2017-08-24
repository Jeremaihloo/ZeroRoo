using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Net;

namespace ZeroRoo.Apps.Services
{
    public class HtmlActivity : BaseActivity
    {
        public HtmlActivity()
        {
            this.RoutePattern = ".*?\\.(html|css|js|png|jpg|jpeg|gif)";
        }

        public override void OnView(HttpListenerRequest req, HttpListenerResponse res)
        {
            var ext = req.RawUrl.Substring(req.RawUrl.LastIndexOf("."));
            res.ContentType = MimeTypes.GetMimeType(ext);
            WriteViewContent(res, req.RawUrl);
        }
    }
}
