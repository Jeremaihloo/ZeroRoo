using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.FileSystem
{
    public static class FileSystemExtensions
    {
        public static IServiceCollection AddDefaultFileSystem(this IServiceCollection builder)
        {
            builder.AddSingleton<IFileSystem, DefaultFileSystem>();
            return builder;
        }
    }
}
