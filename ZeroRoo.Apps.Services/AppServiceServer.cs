using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using WebSocketSharp.Net;
using WebSocketSharp;
using Microsoft.Extensions.Logging;
using System.IO;

namespace ZeroRoo.Apps.Services
{
    public class AppServiceServer : IAppServiceServer
    {
        private HttpServer wss;

        public AppServiceServer(ILogger<AppServiceServer> logger, IEnumerable<IAppService> appServices)
        {
            this.wss = new HttpServer(8000);
            this.wss.AddWebSocketService<AppServiceRoute>("/apps", () => new AppServiceRoute(logger, appServices));

            this.wss.RootPath = AppDomain.CurrentDomain.BaseDirectory;
            
            // Set the HTTP GET request event.
            this.wss.OnGet += Wss_OnGet;
        }
        
        private void Wss_OnGet(object sender, HttpRequestEventArgs e)
        {
            var req = e.Request;
            var res = e.Response;

            var path = req.RawUrl;
            if (path == "/")
                path += "index.html";

            byte[] contents;
            var pDeal = path.Replace("/", "\\");
            if (pDeal.StartsWith("\\"))
            {
                pDeal = pDeal.Substring(1);
            }
            var fp = Path.Combine(this.wss.RootPath, pDeal);
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

        public void Start()
        {
            this.wss.Start();
        }

        public void Stop()
        {
            this.wss.Stop();
        }

        public void AddProxy(string src, string target)
        {
            throw new NotImplementedException();
        }
    }
}
