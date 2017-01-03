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
    public class App : WindowApp
    {
        public override void OnStart()
        {
            var form = new DbMigrationForm();
            this.SetWindow(form);
        }

        public override void OnStop(AppStopEventArgs e)
        {
            
        }
    }
}
