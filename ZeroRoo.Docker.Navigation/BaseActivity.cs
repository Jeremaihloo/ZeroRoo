using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Docker.Navigation
{
    public class BaseActivity : IActivity
    {
        public virtual string HtmlUri { get; set; }
        public virtual string Title { get; set; }
        public virtual string Name { get { return this.GetType().FullName; } }

    }
}
