using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Abstractions.Features
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ZeroRooFeatureAttribute : Attribute
    {
        public ZeroRooFeatureAttribute(string text)
        {
            FeatureName = text;
        }

        public string FeatureName { get; set; }
    }
}
