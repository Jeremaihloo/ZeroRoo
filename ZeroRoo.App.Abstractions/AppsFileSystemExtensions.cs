using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Abstractions
{
    public static class AppsFileSystemExtensions
    {
        public static IFileInfo GetAppFileInfo()
        {
            IFileProvider provider = new PhysicalFileProvider(AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
