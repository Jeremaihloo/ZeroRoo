using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;

namespace ZeroRoo.FileSystem
{
    public class DefaultFileSystem : IFileSystem
    {
        private IRuntimeEnviroment env;

        public DefaultFileSystem(IRuntimeEnviroment env)
        {
            this.env = env;
        }

        public void Add(IFileProvider fileProvider)
        {
            throw new NotImplementedException();
        }

        public void Delete(IFileProvider fileProvider)
        {
            throw new NotImplementedException();
        }

        public IFileInfo GetAppsDir()
        {
            return this.env.RootFileProvider.GetFileInfo("Apps");
        }

        public IFileInfo GetDesktopFilesDir()
        {
            return this.env.RootFileProvider.GetFileInfo("DesktopFiles");
        }

        public void Remove(IFileProvider sourceFile, IFileProvider targetFile)
        {
            throw new NotImplementedException();
        }
    }
}
