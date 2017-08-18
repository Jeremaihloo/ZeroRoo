using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.FileSystem
{
    public interface IFileSystem
    {
        IFileInfo GetAppsDir();

        IFileInfo GetDesktopFilesDir();

        void Add(IFileProvider fileProvider);

        void Delete(IFileProvider fileProvider);

        void Remove(IFileProvider sourceFile, IFileProvider targetFile);
    }
}
