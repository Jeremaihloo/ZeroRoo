using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker.Shapes
{
    public class MenuItemButtonsProvider : IMenuItemButtonProvider
    {
        private DockerShapeContext context;
        public MenuItemButtonsProvider(DockerShapeContext context)
        {
            this.context = context;
        }

        public IEnumerable<IShape> GetButtons(IMenuItemButtonBuilder builder, IEnumerable<MenuItem> items)
        {
            return items.Select(item => builder.Build(context, item));
        }
    }
}
