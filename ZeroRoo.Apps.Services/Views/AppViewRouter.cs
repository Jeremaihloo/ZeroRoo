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
        private IEnumerable<IActivity> activities;
        public AppViewRouter(IEnumerable<IActivity> activities)
        {
            this.activities = activities;
        }

        public IActivity Match(string path)
        {
            foreach(var item in this.activities)
            {
                var reg = new Regex(item.RoutePattern);
                if(reg.IsMatch(path))
                {
                    return item;
                }
            }
            return new NotFoundActivity();
        }
    }
}
