using ZeroRoo.Apps.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Features;

namespace ZeroRoo.Apps
{
    internal class CompositeAppOrderingStrategy : IAppOrderingStrategy
    {
        private readonly IAppOrderingStrategy[] _extensionOrderingStrategies;
        public CompositeAppOrderingStrategy(params IAppOrderingStrategy[] extensionOrderingStrategies)
        {
            _extensionOrderingStrategies = extensionOrderingStrategies ?? new IAppOrderingStrategy[0];
        }

        public CompositeAppOrderingStrategy(IEnumerable<IAppOrderingStrategy> extensionOrderingStrategies)
        {
            if (extensionOrderingStrategies == null)
            {
                throw new ArgumentNullException(nameof(extensionOrderingStrategies));
            }
            _extensionOrderingStrategies = extensionOrderingStrategies.ToArray();
        }

        public double Priority { get { throw new NotSupportedException(); } }

        public int Compare(IFeatureInfo observer, IFeatureInfo subject)
        {
            foreach (var strategy in _extensionOrderingStrategies.OrderByDescending(x => x.Priority))
            {
                var compare = strategy.Compare(observer, subject);
                if (compare != 0)
                {
                    return compare;
                }
            }
            return 0;
        }
    }
}
