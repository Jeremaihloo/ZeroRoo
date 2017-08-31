using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.DefaultApp.Services
{
    public class ApplicationExit : IAppService
    {
        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            Application.Exit();
        }
    }
}
