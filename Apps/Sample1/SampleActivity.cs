using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace Sample1
{
    public partial class SampleActivity : BaseActivity
    {
        public SampleActivity()
            :base()
        {
            this.HtmlUri = "sample.html";
            this.Title = "实例";
        }
    }
}
