using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker.Shapes
{
    public class MenuItemButton: IShape
    {
        public string Text { get; set; }
        public string Name { get; set; }
        public MenuItem MenuItem { get; set; }

        //public event EventHandler Click;
    }
}
