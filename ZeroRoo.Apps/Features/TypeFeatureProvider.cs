using System;
using System.Collections.Concurrent;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Features;
using ZeroRoo.Apps.Features;

namespace ZeroRoo.Apps
{
    public class TypeFeatureProvider : ITypeFeatureProvider
    {
        private readonly ConcurrentDictionary<Type, IFeatureInfo> _features 
            = new ConcurrentDictionary<Type, IFeatureInfo>();

        private static readonly IFeatureInfo CoreFeature 
            = new InternalFeatureInfo("Core", new InternalAppInfo("Core"));

        public IFeatureInfo GetFeatureForDependency(Type dependency)
        {
            IFeatureInfo feature = null;

            if(_features.TryGetValue(dependency, out feature))
            {
                return feature;
            }

            return CoreFeature;
        }

        public void TryAdd(Type type, IFeatureInfo feature)
        {
            _features.TryAdd(type, feature);
        }
    }
}