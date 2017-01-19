using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Features;
using ZeroRoo.Apps.Abstractions.Loaders;
using ZeroRoo.Apps.Abstractions.Manifests;
using ZeroRoo.Apps.Features;
using ZeroRoo.Apps.Loaders;
using ZeroRoo.Apps.Manifests;

namespace ZeroRoo.Apps
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add host level services for managing extensions.
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection AddAppManagerHost(
            this IServiceCollection services,
            string rootProbingName,
            string dependencyProbingDirectoryName)
        {
            services.AddSingleton<IManifestBuilder, ManifestBuilder>();
            services.AddSingleton<IManifestProvider, ManifestProvider>();
            services.TryAddEnumerable(
                ServiceDescriptor.Transient<IConfigureOptions<ManifestOptions>, ManifestOptionsSetup>());

            services.AddSingleton<IAppProvider, AppProvider>();
            services.AddSingleton<IAppManager, AppManager>();
            {
                services.AddSingleton<ITypeFeatureProvider, TypeFeatureProvider>();
                services.AddSingleton<IFeaturesProvider, FeaturesProvider>();

                services.TryAddEnumerable(
                    ServiceDescriptor.Transient<IConfigureOptions<AppOptions>, AppOptionsSetup>());


                services.AddSingleton<IAppLoader, DefaultAppLoader>();

                services.Configure<AppProbingOptions>(options =>
                {
                    options.RootProbingName = rootProbingName;
                    options.DependencyProbingDirectoryName = dependencyProbingDirectoryName;
                });

                services.AddSingleton<IAppLibraryService, AppLibraryService>();
            }

            return services;
        }

        public static IServiceCollection AddAppManager(this IServiceCollection services)
        {
            services.TryAddScoped<IFeaturesProvider, FeaturesProvider>();
            services.TryAddTransient<IFeatureHash, FeatureHash>();

            return services;
        }

        public static IServiceCollection AddAppLocation(
            this IServiceCollection services,
            string subPath)
        {
            return services.Configure<AppOptions>(configureOptions: options =>
            {
                options.SearchPaths.Add(subPath);
            });
        }
    }
}