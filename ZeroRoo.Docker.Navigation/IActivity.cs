using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Docker.Navigation
{
    public interface IActivity
    {

        string HtmlUri { get; set; }

        string Title { get; set; }

        string Name { get; }

    }
}
