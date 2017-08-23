using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    public interface IAppViewRoute
    {
        string RoutePattern { get; set; }
        IAppViewHandler Handler { get; set; }
        bool IsMatch(string path);
    }
}
