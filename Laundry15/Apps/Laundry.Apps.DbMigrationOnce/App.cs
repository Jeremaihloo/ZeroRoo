using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.App;
using Laundry.Configuration.Models;
using Laundry.Configuration;
using System.IO;

namespace Laundry.Apps.DbMigrationOnce
{
    public class App : IApp
    {
        public event EventHandler Stop;

        public void OnStart(IAppEnviroment env, AppSystem system)
        {
            DbMigrationForm form = new DbMigrationForm();
            form.SetDebug((bool)env.Get("IFDEBUG"));
            form.ShowDialog();
            if (form.HasFinish)
            {
                env.AppConfig.Enable = false;
                env.AppConfig.Visible = false;
            }
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
