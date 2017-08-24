using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    public class HtmlViewRoute : AppViewRouteAttribute
    {
        public HtmlViewRoute() 
        {
            this.RoutePattern = ".*?\\.(html|png|jpg|jpeg|gif|ico).*?";
            this.Handler = new HtmlViewHandler();
        }
    }
}
