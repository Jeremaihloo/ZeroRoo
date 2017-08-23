using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker.Shapes
{
    public interface IMenuItemButtonProvider: IShapeProvider
    {
        IEnumerable<IShape> GetButtons(IMenuItemButtonBuilder builder, IEnumerable<MenuItem> items);
    }
}
