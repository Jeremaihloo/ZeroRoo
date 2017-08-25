using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using Newtonsoft.Json;

namespace ZeroRoo.Apps.Services
{
    public class AppServiceRoute: WebSocketBehavior
    {
        private IEnumerable<IAppService> appServices;
        private ILogger logger;

        public AppServiceRoute(ILogger logger, IEnumerable<IAppService> appServices)
        {
            this.logger = logger;
            this.appServices = appServices;
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            this.Send("test");
            return;

            var message = JsonConvert.DeserializeObject<AppServiceMessage>(e.Data);
            
            try
            {
                var service = this.appServices.FirstOrDefault(h => h.GetType().FullName == message.Service);
                if (service == null)
                {
                    // logger
                    throw new Exception($"Service Not Found {message.Service}");
                }

                service.OnService(this, message);
            }
            catch(Exception ex)
            {
                message.Data = ex.Message;
                message.Ok = false;
            }
            SendMessage(message);
        }

        public void SendMessage(AppServiceMessage msg)
        {
            Send(JsonConvert.SerializeObject(msg));
        }

        protected override void OnError(ErrorEventArgs e)
        {
            base.OnError(e);
        }

        protected override void OnClose(CloseEventArgs e)
        {
            base.OnClose(e);
        }

        protected override void OnOpen()
        {
            base.OnOpen();
        }
    }
}
