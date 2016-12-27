using ZeroRoo.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.Apps.Search
{
    public class App : IApp
    {
        public event EventHandler Stop;

        public void OnStart(IAppEnviroment env, AppSystem system)
        {
            SearchForm form = new SearchForm();
            form.Show();
        }

        public void OnStop()
        {
            
        }

        public void OnStop(IAppEnviroment env, AppSystem system, AppStopEventArgs e)
        {
            
        }

        public void OnWakeUp(IAppEnviroment env, AppSystem system)
        {
            
        }
    }
}
