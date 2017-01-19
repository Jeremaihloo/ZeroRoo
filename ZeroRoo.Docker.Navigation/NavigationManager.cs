using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.Extensions.Logging;

namespace ZeroRoo.Docker.Navigation
{
    public class NavigationManager : INavigationManager
    {
        private static string[] Schemes = new[] { "app", "http", "https", "tel", "mailto" };

        private readonly IEnumerable<INavigationProvider> _navigationProviders;
        private readonly ILogger _logger;

        public NavigationManager(
            IEnumerable<INavigationProvider> navigationProviders,
            ILogger<NavigationManager> logger)
        {
            _navigationProviders = navigationProviders;
            _logger = logger;
        }

        public IEnumerable<MenuItem> BuildMenu()
        {
            var builder = new NavigationBuilder();

            // Processes all navigation builders to create a flat list of menu items.
            // If a navigation builder fails, it is ignored.
            foreach (var navigationProvider in _navigationProviders)
            {
                try
                {
                    navigationProvider.BuildNavigation(builder);
                }
                catch (Exception e)  
                {
                    _logger.LogError($"An exception occured while building the menu: ", e);
                }
            }

            var menuItems = builder.Build();

            return menuItems;
        }
    }
}
