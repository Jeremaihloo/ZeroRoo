using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Apps.Services
{
    public class AppViewRouter
    {
        private IEnumerable<IAppViewRoute> routes;
        public AppViewRouter(IEnumerable<IAppViewRoute> routes)
        {
            this.routes = routes;
        }

        public IAppViewHandler Match(string path)
        {
            foreach(var item in this.routes)
            {
                if(item.IsMatch(path))
                {
                    return item.Handler;
                }
            }
            return new NotFoundViewHandler();
        }
    }
}
