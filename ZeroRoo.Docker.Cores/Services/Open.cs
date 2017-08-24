using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker.Cores.Services
{
    public class Open : IAppService
    {
        private IServiceCollection services;

        public Open(IServiceCollection services)
        {
            this.services = services;
        }

        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            var provider = this.services.BuildServiceProvider();
            var router = provider.GetRequiredService<AppViewRouter>();
            var activity = router.Match(msg.Data.ToString());
            if (activity == null)
            {
                // TODO:
            }
            else
            {
                msg.Data = new { Activity = activity, Target = msg.Data };
            }
            route.SendMessage(msg);
        }
    }
}
