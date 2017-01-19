using System;
using System.Collections.Generic;
using System.Linq;

namespace ZeroRoo.Docker.Navigation
{
    public class NavigationBuilder
    {
        List<MenuItem> Contained { get; set; }

        public NavigationBuilder()
        {
            Contained = new List<MenuItem>();
        }

        public NavigationBuilder Add(string name, string caption, string icon, Action<NavigationItemBuilder> itemBuilder)
        {
            var childBuilder = new NavigationItemBuilder();

            childBuilder.Name(name);
            childBuilder.Icon(icon);
            childBuilder.Caption(caption);
            itemBuilder(childBuilder);
            Contained.AddRange(childBuilder.Build());

            return this;
        }

        public NavigationBuilder Remove(MenuItem item)
        {
            Contained.Remove(item);
            return this;
        }

        public List<MenuItem> Build()
        {
            return (Contained ?? new List<MenuItem>()).ToList();
        }
    }
}
