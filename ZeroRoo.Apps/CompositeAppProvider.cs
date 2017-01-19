using System;
using System.Collections.Generic;
using System.Linq;
using ZeroRoo.Apps.Abstractions;

namespace ZeroRoo.Apps
{
    internal class CompositeAppProvider : IAppProvider
    {
        private readonly IAppProvider[] _extensionProviders;
        public CompositeAppProvider(params IAppProvider[] extensionProviders)
        {
            _extensionProviders = extensionProviders ?? new IAppProvider[0];
        }

        public CompositeAppProvider(IEnumerable<IAppProvider> extensionProviders)
        {
            if (extensionProviders == null)
            {
                throw new ArgumentNullException(nameof(extensionProviders));
            }
            _extensionProviders = extensionProviders.ToArray();
        }

        public IAppInfo GetAppInfo(string subPath)
        {
            foreach (var provider in _extensionProviders)
            {
                var extensionInfo = provider.GetAppInfo(subPath);
                if (extensionInfo != null)
                {
                    return extensionInfo;
                }
            }
            return new InternalAppInfo(subPath);
        }
    }
}
