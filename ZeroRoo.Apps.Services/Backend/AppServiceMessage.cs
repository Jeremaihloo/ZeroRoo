using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    public class AppServiceMessage
    {
        public string Service { get; set; }

        public object Data { get; set; }

        public bool Ok { get; set; }

        public AppServiceMessage(string service, object data)
        {
            this.Service = service;
            this.Data = data;
            this.Ok = true;
        }
    }
}
