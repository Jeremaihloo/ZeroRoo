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
    public partial class SampleActivity : IActivity
    {
        public SampleActivity()
        {
            this.HtmlUri = "sample.html";
        }

        public string HtmlUri { get; set; }

        public void OnActive()
        {
            
        }

        public void OnCreate()
        {
            
        }
    }
}
