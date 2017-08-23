using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Docker.Shapes
{
    public interface IShapeContainer
    {
        void AddRange(IEnumerable<IShape> items);
        void Add(IShape item);
    }
}
