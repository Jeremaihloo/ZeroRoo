using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Docker.Navigation
{
    public interface IActivityManager
    {
        void Active(IActivity activity);
    }
}
