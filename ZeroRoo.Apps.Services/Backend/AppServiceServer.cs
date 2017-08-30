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
using Newtonsoft.Json;
using System.Threading;

namespace ZeroRoo.Apps.Services
{
    public class AppServiceServer : IAppServiceServer
    {
        private HttpServer wss;
        private AppViewRouter appViewRouter;
        private Queue<AppServiceMessage> msgQueue;

        public AppServiceServer(ILogger<AppServiceServer> logger, IEnumerable<IAppService> appServices, AppViewRouter appViewRouter)
        {
            this.appViewRouter = appViewRouter;
            this.msgQueue = new Queue<AppServiceMessage>();

            this.wss = new HttpServer(8000);
            this.wss.AddWebSocketService<AppServiceRoute>("/apps", () => new AppServiceRoute(logger, appServices));

            this.wss.RootPath = AppDomain.CurrentDomain.BaseDirectory;
            
            // Set the HTTP GET request event.
            this.wss.OnGet += Wss_OnGet;

            //this.wss.Start();
        }

        public void SendMessage(AppServiceMessage msg)
        {
            msgQueue.Enqueue(msg);
        }

        private void Wss_OnGet(object sender, HttpRequestEventArgs e)
        {
            var req = e.Request;
            var res = e.Response;

            var path = req.Url.OriginalString;

            var handler = this.appViewRouter.Match(path);

            if (handler != null)
            {
                handler.OnView(req, res);
            }

            // TODO: log
        }

        public void Start()
        {
            this.wss.Start();
            ThreadPool.QueueUserWorkItem(state =>
            {
                while (true)
                {
                    if (msgQueue.Count > 0)
                    {
                        var msg = msgQueue.Dequeue();
                        this.wss.WebSocketServices.Broadcast(JsonConvert.SerializeObject(msg));
                        Thread.Sleep(2000);
                    }
                }
            });
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
