using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    public class AppServiceMessage
    {
        public string ServiceName { get; set; }

        public string Action { get; set; } 

        public object Data { get; set; }

        public bool Ok { get; set; }

        public AppServiceMessage(string topic, object data)
        {
            this.ServiceName = topic;
            this.Data = data;
            this.Ok = true;
        }
    }
}
