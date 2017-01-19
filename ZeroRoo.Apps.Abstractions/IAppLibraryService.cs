using System.Collections.Generic;
using System.Reflection;

namespace ZeroRoo.Apps.Abstractions
{
    /// <summary>
    /// Provides extension library utilities.
    /// Its lifetime is a host level singleton.
    /// </summary>
    public interface IAppLibraryService
    {
        /// <summary>
        /// Loads an ambient extension.
        /// Returns an <see cref="Assembly"/> instance.
        /// </summary>
        Assembly LoadAppAssembly(IAppInfo extensionInfo);
    }
}