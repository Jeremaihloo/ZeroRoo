using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using WebSocketSharp;
using Microsoft.Extensions.Logging;

namespace ZeroRoo.Apps.Services
{
    public class AppServiceServer : IAppServiceServer
    {
        private WebSocketServer wss;

        public AppServiceServer(ILogger<AppServiceServer> logger, IEnumerable<IAppService> appServices)
        {
            this.wss = new WebSocketServer(8000);
            this.wss.AddWebSocketService<AppServiceRoute>("/apps", () => new AppServiceRoute(logger, appServices));
        }

        public void Start()
        {
            this.wss.Start();
        }

        public void Stop()
        {
            this.wss.Stop();
        }
    }
}
