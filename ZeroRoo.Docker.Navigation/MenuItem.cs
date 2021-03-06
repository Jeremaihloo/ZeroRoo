﻿using System;
using System.Collections.Generic;

namespace ZeroRoo.Docker.Navigation
{
    /// <summary>
    /// Represents a menu item descrbibed by an <see cref="INavigationProvider"/> implementation.
    /// A menu item can desbribe child menu items.
    /// </summary>
    public class MenuItem
    {
        public MenuItem()
        {
            Items = new List<MenuItem>();
        }

        /// <summary>
        /// App Name
        /// </summary>
        public string App { get; set; }

        /// <summary>
        /// The name to id the menu item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The icon file name to show a menu button
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The text to display with the menu item.
        /// </summary>
        public string Text { get; set; }
        
        /// <summary>
        /// Target
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// The child menu items.
        /// </summary>
        ///
        public List<MenuItem> Items { get; set; }

    }
}
