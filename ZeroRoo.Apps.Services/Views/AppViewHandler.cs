using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Net;

namespace ZeroRoo.Apps.Services
{
    public class BaseViewHandler : IAppViewHandler
    {
        public virtual void Handle(HttpListenerRequest req, HttpListenerResponse res)
        {
            res.ContentEncoding = Encoding.UTF8;
            res.ContentType = "text/html; charset=utf-8";
        }
    }

    public class NotFoundViewHandler : BaseViewHandler
    {
        public override void Handle(HttpListenerRequest req, HttpListenerResponse res)
        {
            res.StatusCode = (int)HttpStatusCode.NotFound;
            res.WriteContent(Encoding.UTF8.GetBytes("<h1>NotFound</h1>"));
        }
    }

    public class HtmlViewHandler : BaseViewHandler
    {
        private static IList<string> defaultHtmls = new List<string>()
        {
            "index.html",
            "default.html",
            "home.html"
        };

        public override void Handle(HttpListenerRequest req, HttpListenerResponse res)
        {
            var path = req.RawUrl;
            if (req.RawUrl == "/")
                path += "index.html";

            byte[] contents;
            var pDeal = path.Replace("/", "\\");
            if (pDeal.StartsWith("\\"))
            {
                pDeal = pDeal.Substring(1);
            }
            var fp = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pDeal);
            if (!File.Exists(fp))
            {
                res.StatusCode = (int)HttpStatusCode.NotFound;
                return;
            }

            contents = File.ReadAllBytes(fp);
            res.ContentEncoding = Encoding.UTF8;

            var ext = path.Substring(path.LastIndexOf('.'));
            res.ContentType = MimeTypes.GetMimeType(ext);

            res.WriteContent(contents);
        }
    }
}
