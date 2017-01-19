using System;
using System.Collections.Generic;
using System.Linq;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Loaders;

namespace ZeroRoo.Apps.Loaders
{
    internal class CompositeAppLoader : IAppLoader
    {
        private readonly IAppLoader[] _extensionLoaders;

        public CompositeAppLoader(params IAppLoader[] extensionLoaders)
        {
            _extensionLoaders = extensionLoaders ?? new IAppLoader[0];
        }

        public CompositeAppLoader(IEnumerable<IAppLoader> extensionLoaders)
        {
            if (extensionLoaders == null)
            {
                throw new ArgumentNullException(nameof(extensionLoaders));
            }
            _extensionLoaders = extensionLoaders.ToArray();
        }

        public string Name
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        public int Order
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        public AppEntry Load(IAppInfo extensionInfo)
        {
            foreach (var loader in _extensionLoaders.OrderByDescending(x => x.Order))
            {
                var entry = loader.Load(extensionInfo);
                if (entry != null)
                {
                    return entry;
                }
            }
            return new AppEntry { ExtensionInfo = extensionInfo, IsError = true };
        }
    }
}
