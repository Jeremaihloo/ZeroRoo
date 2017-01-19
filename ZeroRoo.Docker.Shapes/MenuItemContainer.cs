using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Q.Controls;

namespace ZeroRoo.Docker.Shapes
{
    public class MenuItemContainer : QPanel, IShapeContainer
    {
        void IShapeContainer.Add(IShape item)
        {
            this.Controls.Add(item as DSkin.Controls.DSkinBaseControl);
        }

        void IShapeContainer.AddRange(IEnumerable<IShape> items)
        {
            this.Controls.AddRange(items.Select(item=>item as DSkin.Controls.DSkinBaseControl).ToArray());
        }
    }
}
