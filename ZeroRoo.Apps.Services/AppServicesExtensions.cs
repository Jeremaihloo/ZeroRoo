﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Services
{
    public static class AppServicesExtensions
    {
        public static IServiceCollection AddAppsServices(this IServiceCollection services)
        {
            services.AddSingleton<IAppServiceServer, AppServiceServer>();
            services.AddSingleton<AppServiceRoute>();
            services.AddSingleton<AppViewRouter>();
            services.AddScoped<IActivity, HtmlActivity>();
            return services;
        }

        public static IServiceProvider UseAppsServices(this IServiceProvider provider)
        {
            var server = provider.GetRequiredService<IAppServiceServer>();
            server.Start();
            return provider;
        }
    }
}
