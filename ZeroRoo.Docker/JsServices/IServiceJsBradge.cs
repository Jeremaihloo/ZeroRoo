using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Docker.JsServices
{
    public interface IServiceJsBradge
    {
        string Call(string topic, string argJsonString);
    }
}
