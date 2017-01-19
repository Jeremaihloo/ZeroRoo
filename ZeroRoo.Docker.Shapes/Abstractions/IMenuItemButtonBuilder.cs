using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker.Shapes
{
    public interface IMenuItemButtonBuilder: IShapeBuilder
    {
        IShape Build(DockerShapeContext context, MenuItem menuItem);
    }
}
