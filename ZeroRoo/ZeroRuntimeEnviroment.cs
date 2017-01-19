using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace ZeroRoo
{
    public class ZeroRuntimeEnviroment : IRuntimeEnviroment
    {
        public string ApplicationName => "ZeroRoo";

        public IFileProvider RootFileProvider { get; set; }

        public string EnviromentName => "Development";

        public string RootPath => Directory.GetCurrentDirectory();
    }
}
