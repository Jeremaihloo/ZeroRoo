using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ZeroRoo.Apps.Abstractions;

namespace ZeroRoo.Apps
{
    public class AppLibraryService : IAppLibraryService
    {
        private readonly string _probingDirectoryName;
        private static readonly Object _syncLock = new Object();

        private static readonly ConcurrentDictionary<string, Assembly> _loadedAssemblies = new ConcurrentDictionary<string, Assembly>(StringComparer.OrdinalIgnoreCase);
        private static readonly ConcurrentDictionary<string, string> _compileOnlyAssemblies = new ConcurrentDictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private readonly IRuntimeEnviroment _runtimeEnvironment;
        private readonly string _probingFolderPath;
        private readonly ILogger _logger;

        public AppLibraryService(
            IRuntimeEnviroment runtimeEnvironment,
            IOptions<AppProbingOptions> optionsAccessor,
            ILogger<IAppLibraryService> logger)
        {
            _runtimeEnvironment = runtimeEnvironment;
            _probingDirectoryName = optionsAccessor.Value.DependencyProbingDirectoryName;
            _probingFolderPath = _runtimeEnvironment.RootFileProvider.GetFileInfo(Path.Combine(optionsAccessor.Value.RootProbingName, _probingDirectoryName)).PhysicalPath;
            _logger = logger;

            foreach (var item in GetApplicationAssemblyNames())
            {
                _loadedAssemblies.TryAdd(item.Key, item.Value);
            }

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<KeyValuePair<string, Assembly>> GetApplicationAssemblyNames()
        { 
            var list = AppDomain.CurrentDomain.GetAssemblies().Select(item => new KeyValuePair<string, Assembly>(item.GetName().Name, item));
            return list;
        }

        public Assembly LoadAppAssembly(IAppInfo appInfo)
        {

            if (IsAssemblyLoaded(appInfo.Id))
            {
                return _loadedAssemblies[appInfo.Id];
            }

            LoadAppModule(appInfo);


            return IsAssemblyLoaded(appInfo.Id) ? _loadedAssemblies[appInfo.Id] : null;
        }
        
        internal void LoadAppModule(IAppInfo appInfo)
        {
            var fileInfo = appInfo.AppFileInfo;
            var assemblyFolderPath = Path.Combine(fileInfo.PhysicalPath);
            var assemblyPath = Path.Combine(assemblyFolderPath, appInfo.Id + ".dll");

            if (!Directory.Exists(assemblyFolderPath))
            {
                return;
            }

            var assembly = LoadFromAssemblyPath(assemblyPath);
            //var refs = assembly.GetReferencedAssemblies();
            //foreach (var item in refs)
            //{

            //    if (!IsAssemblyLoaded(item.Name))
            //    {
            //        LoadFromAssemblyPath(item.Name);
            //    }
            //}

        }
        
        private bool IsAssemblyLoaded(string assemblyName)
        {
            return _loadedAssemblies.ContainsKey(assemblyName);
        }

        private Assembly LoadFromAssemblyPath(string assemblyPath)
        {
            try
            {
                var name = Path.GetFileNameWithoutExtension(assemblyPath);
                return _loadedAssemblies.GetOrAdd(name, 
                    Assembly.LoadFrom(assemblyPath));
            }
            catch (Exception ex)
            {
                _logger.LogCritical("Load Assembly error", ex.Message);
                return null;
            }
        }
    }
}
