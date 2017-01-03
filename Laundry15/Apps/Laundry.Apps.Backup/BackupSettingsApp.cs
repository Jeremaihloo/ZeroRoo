using ZeroRoo.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.Apps.Backup
{
    public class BackupSettingsApp : WindowApp
    {
        public override void OnStart()
        {
            var form = new BackupSettingsForm();
            this.SetWindow(form);
        }
    }
}
