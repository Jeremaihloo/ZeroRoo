using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.App;

namespace Laundry.Apps.CameraData
{
    public class CameraDataBackupSettingsApp : WindowApp
    {
        public override void OnStart()
        {
            var form = new CameraDataBackupSettingsForm();
            this.SetWindow(form);
        }
    }
}
