﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ZeroRoo.Docker.Navigation
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
         /// Adds tenant level services.
         /// </summary>
         /// <param name="services"></param>
         /// <returns></returns>
        public static IServiceCollection AddNavigation(this IServiceCollection services)
        {
            services.TryAddScoped<INavigationManager, NavigationManager>();
            return services;
        }
    }
}
