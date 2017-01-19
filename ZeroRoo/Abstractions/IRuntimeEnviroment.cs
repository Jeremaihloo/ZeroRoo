using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo
{
    public interface IRuntimeEnviroment
    {
        string EnviromentName { get; }

        string ApplicationName { get; }

        string RootPath { get; }

        IFileProvider RootFileProvider { get; }
    }
}
