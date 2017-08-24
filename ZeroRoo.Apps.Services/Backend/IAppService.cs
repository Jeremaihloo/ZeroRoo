using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    public interface IAppService
    {
        void OnService(AppServiceRoute route, AppServiceMessage msg);
    }
}
