using System;
using System.Collections.Generic;

namespace ZeroRoo.Docker.Navigation
{
    public class NavigationItemBuilder : NavigationBuilder
    {
        private readonly MenuItem _item;

        public NavigationItemBuilder()
        {
            _item = new MenuItem();
        }

        public NavigationItemBuilder(MenuItem existingItem)
        {
            if (existingItem == null)
            {
                throw new ArgumentNullException(nameof(existingItem));
            }

            _item = existingItem;
        }

        public NavigationItemBuilder App(string appName)
        {
            _item.App = appName;
            return this;
        }

        public NavigationItemBuilder Name(string name)
        {
            _item.Name = name;
            return this;
        }

        public NavigationItemBuilder Icon(string icon)
        {
            _item.Icon = icon;
            return this;
        }

        public NavigationItemBuilder Caption(string caption)
        {
            _item.Text = caption;
            return this;
        }

        public NavigationItemBuilder Target(string target)
        {
            _item.Target = target;
            return this;
        }

        public new IEnumerable<MenuItem> Build()
        {
            _item.Items = base.Build();
            return new[] { _item };
        }
    }
}