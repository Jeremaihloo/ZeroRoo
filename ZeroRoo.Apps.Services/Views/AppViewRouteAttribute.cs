using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AppViewRouteAttribute : Attribute
    {
        public string RoutePattern { get; set; }

        public AppViewRouteAttribute(string routePattern)
        {
            this.RoutePattern = routePattern;
        }
        
        public bool IsMatch(string path)
        {
            var reg = new Regex(this.RoutePattern);
            return reg.IsMatch(path);
        }
    }
}
