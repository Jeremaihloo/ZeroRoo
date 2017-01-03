using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public interface IAppEnviroment : IEnviroment
    {
        AppConfig AppConfig { get; set; }
    }
}
