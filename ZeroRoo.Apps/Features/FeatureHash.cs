using Microsoft.Extensions.Caching.Memory;
using System.Linq;
using System.Threading.Tasks;
using ZeroRoo.Apps.Abstractions.Features;

namespace ZeroRoo.Apps.Features
{
    public class FeatureHash : IFeatureHash
    {
        private const string FeatureHashCacheKey = "FeatureHash:Features";

        private readonly IFeaturesManager _featureManager;
        private readonly IMemoryCache _memoryCache;

        public FeatureHash(
            IFeaturesManager featureManager,
            IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _featureManager = featureManager;
        }

        public async Task<int> GetFeatureHashAsync()
        {
            int serial;
            if (_memoryCache.TryGetValue(FeatureHashCacheKey, out serial))
            {
                return serial;
            }

            // Calculate a hash of all enabled features' id
            var enabledFeatures = await _featureManager.GetEnabledFeaturesAsync();
            serial = enabledFeatures
                .OrderBy(x => x.Id)
                .Aggregate(0, (a, f) => a * 7 + f.Id.GetHashCode());

            _memoryCache.Set(FeatureHashCacheKey, serial);

            return serial;
        }

        public async Task<int> GetFeatureHashAsync(string featureId)
        {
            var cacheKey = string.Format("{0}:{1}", FeatureHashCacheKey, featureId);
            bool enabled;
            if (!_memoryCache.TryGetValue(cacheKey, out enabled))
            {
                var enabledFeatures = await _featureManager.GetEnabledFeaturesAsync();
                enabled =
                    enabledFeatures
                        .Any(x => x.Id.Equals(featureId));

                _memoryCache.Set(cacheKey, enabled);
            }

            return enabled ? 1 : 0;
        }
    }
}
