using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Docker.Navigation
{
    public interface IActivity
    {
        void OnActive();

        void OnCreate();

        string HtmlUri { get; set; }
    }
}
