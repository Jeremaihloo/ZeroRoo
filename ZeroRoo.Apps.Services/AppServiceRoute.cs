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
            var message = JsonConvert.DeserializeObject<AppServiceMessage>(e.Data);

            var service = this.appServices.FirstOrDefault(h => h.GetType().FullName == message.ServiceName);
            if (service == null)
            {
                // logger
                return;
            }
            var method = service.GetType().GetMethod(message.Action);
            if (method == null)
            {
                // logger
                return;
            }
            var result = method.Invoke(service, new object[] { message });
            if(!(result is AppServiceMessage))
            {
                message.Data = result;
            }
            else
            {
                message = result as AppServiceMessage;
            }

            Send(JsonConvert.SerializeObject(message));
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
