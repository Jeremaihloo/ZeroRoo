using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Net;

namespace ZeroRoo.Apps.Services
{
    public interface IActivity
    {
        string Title { get; set; }

        string RoutePattern { get; set; }

        void OnView(HttpListenerRequest req, HttpListenerResponse res);
    
    }
}
