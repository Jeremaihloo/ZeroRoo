using System;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.FileProviders.Physical;
using System.IO;

namespace ZeroRoo.FileSystem.FileSystems
{
    public class RootFileSystem : IFileSystem
    {
        IFileInfo info = null;
        IFileProvider provider = null;

        public RootFileSystem()
        {
            this.provider = new PhysicalFileProvider(".");
            this.info = this.provider.GetFileInfo("");
        }

        public void Add(IFileProvider fileProvider)
        {

        }

        public void Delete(IFileProvider fileProvider)
        {
            throw new NotImplementedException();
        }

        public IFileInfo GetAppsDir()
        {
            throw new NotImplementedException();
        }

        public IFileInfo GetDesktopFilesDir()
        {
            throw new NotImplementedException();
        }

        public void Remove(IFileProvider sourceFile, IFileProvider targetFile)
        {
            throw new NotImplementedException();
        }
    }
}
