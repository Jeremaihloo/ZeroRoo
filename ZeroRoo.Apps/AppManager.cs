using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ZeroRoo.Apps.Features;
using ZeroRoo.Apps.Loaders;
using System.Threading;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Loaders;
using ZeroRoo.Apps.Abstractions.Features;
using ZeroRoo.Apps.Abstractions.Utility;

namespace ZeroRoo.Apps
{
    public class AppManager : IAppManager
    {
        private readonly AppOptions _extensionOptions;
        private readonly IAppProvider _extensionProvider;
        private readonly IAppLoader _extensionLoader;
        private readonly IAppOrderingStrategy _extensionOrderingStrategy;
        private readonly IRuntimeEnviroment _hostingEnvironment;
        private readonly ITypeFeatureProvider _typeFeatureProvider;

        private readonly LazyConcurrentDictionary<string, Task<AppEntry>> _extensions
            = new LazyConcurrentDictionary<string, Task<AppEntry>>();

        private readonly LazyConcurrentDictionary<string, Task<FeatureEntry>> _features
            = new LazyConcurrentDictionary<string, Task<FeatureEntry>>();

        private LazyConcurrentDictionary<string, IEnumerable<IFeatureInfo>> _featureDependencies
            = new LazyConcurrentDictionary<string, IEnumerable<IFeatureInfo>>();

        private LazyConcurrentDictionary<string, IEnumerable<IFeatureInfo>> _dependentFeatures
            = new LazyConcurrentDictionary<string, IEnumerable<IFeatureInfo>>();

        private IDictionary<string, IAppInfo> _extensionsById;

        private IList<IFeatureInfo> _allOrderedFeatureInfos;
        private IList<IFeatureInfo> _allUnorderedFeatureInfos;

        private static Func<IFeatureInfo, IFeatureInfo[], IFeatureInfo[]> GetDependantFeaturesFunc =
            new Func<IFeatureInfo, IFeatureInfo[], IFeatureInfo[]>(
                (currentFeature, fs) => fs
                    .Where(f =>
                            f.Dependencies.Any(dep => dep == currentFeature.Id)
                           ).OrderBy(x => x.Id).ToArray());

        private static Func<IFeatureInfo, IFeatureInfo[], IFeatureInfo[]> GetFeatureDependenciesFunc =
            new Func<IFeatureInfo, IFeatureInfo[], IFeatureInfo[]>(
                (currentFeature, fs) => fs
                    .Where(f =>
                            currentFeature.Dependencies.Any(dep => dep == f.Id)
                           ).OrderByDescending(x => x.Id).ToArray());

        public AppManager(
            IOptions<AppOptions> optionsAccessor,
            IEnumerable<IAppProvider> extensionProviders,
            IEnumerable<IAppLoader> extensionLoaders,
            IEnumerable<IAppOrderingStrategy> extensionOrderingStrategies,
            IRuntimeEnviroment hostingEnvironment,
            ITypeFeatureProvider typeFeatureProvider,
            ILogger<AppManager> logger)
        {
            _extensionOptions = optionsAccessor.Value;
            _extensionProvider = new CompositeAppProvider(extensionProviders);
            _extensionLoader = new CompositeAppLoader(extensionLoaders);
            _extensionOrderingStrategy = new CompositeAppOrderingStrategy(extensionOrderingStrategies);
            _hostingEnvironment = hostingEnvironment;
            _typeFeatureProvider = typeFeatureProvider;
            L = logger;
        }

        public ILogger L { get; set; }

        public IAppInfo GetApp(string extensionId)
        {
            GetApps(); // initialize

            if (_extensionsById.ContainsKey(extensionId))
            {
                return _extensionsById[extensionId];
            }

            return new NotFoundAppInfo(extensionId);
        }

        public IEnumerable<IAppInfo> GetApps()
        {
            if (_extensionsById == null)
            {
                var extensionsById = new Dictionary<string, IAppInfo>();

                foreach (var searchPath in _extensionOptions.SearchPaths)
                {
                    foreach (var subDirectory in _hostingEnvironment
                        .RootFileProvider
                        .GetDirectoryContents(searchPath)
                        .Where(x => x.IsDirectory))
                    {
                        var extensionId = subDirectory.Name;

                        if (!extensionsById.ContainsKey(extensionId))
                        {
                            var subPath = Path.Combine(searchPath, extensionId);

                            var extensionInfo =
                                _extensionProvider.GetAppInfo(subPath);

                            if (extensionInfo.AppFileInfo.Exists)
                            {
                                extensionsById.Add(extensionId, extensionInfo);
                            }
                        }
                    }
                }

                _extensionsById = extensionsById;
            }

            return _extensionsById.Values;
        }

        public IEnumerable<IFeatureInfo> GetFeatureDependencies(string featureId)
        {
            return _featureDependencies.GetOrAdd(featureId, (key) =>
            {
                var unorderedFeatures = GetAllUnorderedFeatures().ToArray();

                var feature = unorderedFeatures.FirstOrDefault(x => x.Id == key);
                if (feature == null)
                {
                    return Enumerable.Empty<IFeatureInfo>();
                }

                var dependencies = new HashSet<IFeatureInfo>() { feature };
                var stack = new Stack<IFeatureInfo[]>();

                stack.Push(GetFeatureDependenciesFunc(feature, unorderedFeatures));

                while (stack.Count > 0)
                {
                    var next = stack.Pop();
                    foreach (var dependency in next.Where(dependency => !dependencies.Contains(dependency)))
                    {
                        dependencies.Add(dependency);
                        stack.Push(GetFeatureDependenciesFunc(dependency, unorderedFeatures));
                    }
                }

                return dependencies.Reverse();
            });
        }

        public IEnumerable<IFeatureInfo> GetDependentFeatures(string featureId)
        {
            return _dependentFeatures.GetOrAdd(featureId, (key) =>
            {
                var unorderedFeatures = GetAllUnorderedFeatures().ToArray();

                var feature = unorderedFeatures.FirstOrDefault(x => x.Id == key);
                if (feature == null)
                {
                    return Enumerable.Empty<IFeatureInfo>();
                }

                return
                    GetDependentFeatures(feature, unorderedFeatures);
            });
        }

        private IEnumerable<IFeatureInfo> GetDependentFeatures(
            IFeatureInfo feature,
            IFeatureInfo[] features)
        {
            var dependencies = new HashSet<IFeatureInfo>() { feature };
            var stack = new Stack<IFeatureInfo[]>();

            stack.Push(GetDependantFeaturesFunc(feature, features));

            while (stack.Count > 0)
            {
                var next = stack.Pop();
                foreach (var dependency in next.Where(dependency => !dependencies.Contains(dependency)))
                {
                    dependencies.Add(dependency);
                    stack.Push(GetDependantFeaturesFunc(dependency, features));
                }
            }

            return dependencies;
        }

        public Task<AppEntry> LoadAppAsync(IAppInfo extensionInfo)
        {
            // Results are cached so that there is no mismatch when loading an assembly twice.
            // Otherwise the same types would not match.
            return _extensions.GetOrAdd(extensionInfo.Id, (key) =>
            {
                var extension = _extensionLoader.Load(extensionInfo);

                if (extension.IsError && L.IsEnabled(LogLevel.Warning))
                {

                    L.LogError("No suitable loader found for extension \"{0}\"", extensionInfo.Id);
                }

                return Task.FromResult(extension);
            });
        }

        public async Task<IEnumerable<FeatureEntry>> LoadFeaturesAsync()
        {
            // get loaded feature information
            var loadedFeatures = await Task.WhenAll(GetFeatures()
                .Select(feature => LoadFeatureAsync(feature))
                .ToArray());

            return loadedFeatures.AsEnumerable();
        }

        public IEnumerable<IFeatureInfo> GetFeatures()
        {
            if (_allOrderedFeatureInfos == null)
            {
                _allOrderedFeatureInfos = Order(GetAllUnorderedFeatures());
            }

            return _allOrderedFeatureInfos;
        }

        public IEnumerable<IFeatureInfo> GetFeatures(string[] featureIdsToLoad)
        {
            var allDependencies = featureIdsToLoad
                .SelectMany(featureId => GetFeatureDependencies(featureId))
                .Distinct();

            var orderedFeatureDescriptors = GetFeatures()
                .Where(f => allDependencies.Any(d => d.Id == f.Id));

            return orderedFeatureDescriptors;
        }

        private IList<IFeatureInfo> Order(IEnumerable<IFeatureInfo> featuresToOrder)
        {
            return featuresToOrder
                .OrderBy(x => x.Id)
                .OrderByDependenciesAndPriorities(
                    (fiObv, fiSub) => HasDependency(fiObv, fiSub),
                    (fi) => fi.Priority)
                .ToList();
        }

        public async Task<IEnumerable<FeatureEntry>> LoadFeaturesAsync(string[] featureIdsToLoad)
        {
            var features = GetFeatures(featureIdsToLoad);

            // get loaded feature information
            var loadedFeatures = await Task.WhenAll(features
                .Select(feature => LoadFeatureAsync(feature))
                .ToArray());

            return loadedFeatures.AsEnumerable();
        }

        private bool HasDependency(IFeatureInfo f1, IFeatureInfo f2)
        {
            return _extensionOrderingStrategy.Compare(f1, f2) > 0 ? true : GetFeatureDependencies(f1.Id).Contains(f2);
        }

        private Task<FeatureEntry> LoadFeatureAsync(IFeatureInfo feature)
        {
            return _features.GetOrAdd(feature.Id, async (key) =>
            {
                var loadedExtension = await LoadAppAsync(feature.Extension);

                if (loadedExtension.IsError)
                {
                    return new NonCompiledFeatureEntry(feature);
                }

                var extensionTypes = loadedExtension
                    .ExportedTypes
                    .Where(t => t.GetTypeInfo().IsClass && !t.GetTypeInfo().IsAbstract);

                var featureTypes = new List<Type>();

                foreach (var type in extensionTypes)
                {
                    string sourceFeature = GetSourceFeatureNameForType(type, feature.Id);
                    if (sourceFeature == feature.Id)
                    {
                        featureTypes.Add(type);
                        _typeFeatureProvider.TryAdd(type, feature);
                    }
                }

                return new CompiledFeatureEntry(feature, featureTypes);
            });
        }

        private IList<IFeatureInfo> GetAllUnorderedFeatures()
        {
            if (_allUnorderedFeatureInfos == null)
            {
                _allUnorderedFeatureInfos = GetApps().SelectMany(x => x.Features).ToList();
            }

            return _allUnorderedFeatureInfos;
        }

        private static string GetSourceFeatureNameForType(Type type, string extensionId)
        {
            foreach (ZeroRooFeatureAttribute featureAttribute in type.GetTypeInfo().GetCustomAttributes(typeof(ZeroRooFeatureAttribute), false))
            {
                return featureAttribute.FeatureName;
            }
            return extensionId;
        }

        // https://blogs.endjin.com/2015/10/using-lazy-and-concurrentdictionary-to-ensure-a-thread-safe-run-once-lazy-loaded-collection/
        private class LazyConcurrentDictionary<TKey, TValue>
        {
            private readonly ConcurrentDictionary<TKey, Lazy<TValue>> _concurrentDictionary;

            public LazyConcurrentDictionary()
            {
                _concurrentDictionary = new ConcurrentDictionary<TKey, Lazy<TValue>>();
            }

            // When you call GetOrAdd the valueFactory is not thread safe, this means two threads could make the same
            // call to underlying components.
            // Loading features and extensions is expensive and should only be done once
            public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
            {
                return _concurrentDictionary
                    .GetOrAdd(
                        key, 
                        k => new Lazy<TValue>(() => valueFactory(k), LazyThreadSafetyMode.ExecutionAndPublication))
                    .Value;
            }
        }
    }
}