using Microsoft.Extensions.FileProviders;
using System.IO;
using ZeroRoo;

namespace ZeroRoo.Apps.Abstractions
{
    public static class AppsFileSystemExtensions
    {
        public static IFileInfo GetExtensionFileInfo(
            this IRuntimeEnviroment parentFileSystem,
            IAppInfo extensionInfo,
            string subPath)
        {
            return parentFileSystem.RootFileProvider.GetFileInfo(
                Path.Combine(extensionInfo.SubPath, subPath));
        }
    }
}
