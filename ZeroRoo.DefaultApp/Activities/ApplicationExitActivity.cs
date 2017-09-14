using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.DefaultApp.Activities
{
    public class ApplicationExitActivity : BaseActivity
    {
        public ApplicationExitActivity()
        {
            this.Title = "退出系统";
            this.RoutePattern = "";
        }
    }
}
