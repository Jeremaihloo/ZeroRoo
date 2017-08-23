using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    public class AppViewRoute: IAppViewRoute
    {
        public string RoutePattern { get; set; }
        public IAppViewHandler Handler { get; set; }

        public AppViewRoute()
        {

        }

        public AppViewRoute(string routePattern, IAppViewHandler handler)
        {
            this.RoutePattern = routePattern;
            this.Handler = handler;
        }

        public bool IsMatch(string path)
        {
            var reg = new Regex(this.RoutePattern);
            return reg.IsMatch(path);
        }
    }
}
