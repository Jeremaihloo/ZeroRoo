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
            
        }
        string htmlUri;

        public string HtmlUri
        {
            get
            {
                return "sample.html";
            }
            set
            {
                htmlUri = value;
            }
        }

        public void OnActive()
        {
            
        }

        public void OnCreate()
        {
            
        }
    }
}
