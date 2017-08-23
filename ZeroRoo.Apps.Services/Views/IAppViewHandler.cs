using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Net;

namespace ZeroRoo.Apps.Services
{
    public interface IAppViewHandler
    {
        void Handle(HttpListenerRequest req, HttpListenerResponse res);
    }
}
