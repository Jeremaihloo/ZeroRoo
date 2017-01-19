using System;
using System.Collections.Generic;
using System.Linq;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Features;

namespace ZeroRoo.Apps.Features
{
    internal class CompositeFeaturesProvider : IFeaturesProvider
    {
        private readonly IFeaturesProvider[] _featuresProviders;
        public CompositeFeaturesProvider(params IFeaturesProvider[] featuresProviders)
        {
            _featuresProviders = featuresProviders ?? new IFeaturesProvider[0];
        }
        
        public CompositeFeaturesProvider(IEnumerable<IFeaturesProvider> featuresProviders)
        {
            if (featuresProviders == null)
            {
                throw new ArgumentNullException(nameof(featuresProviders));
            }
            _featuresProviders = featuresProviders.ToArray();
        }

        public IEnumerable<IFeatureInfo> GetFeatures(
            IAppInfo extensionInfo,
            IManifestInfo manifestInfo)
        {
            List<IFeatureInfo> featureInfos = 
                new List<IFeatureInfo>();

            foreach (var provider in _featuresProviders)
            {
                featureInfos.AddRange(provider.GetFeatures(extensionInfo, manifestInfo));
            }

            return featureInfos;
        }
    }
}
