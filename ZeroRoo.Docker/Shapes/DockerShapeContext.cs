using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Docker.Shapes
{
    public class DockerShapeContext
    {
        public Size MenuItemButtonSize { get; set; }

        public int DockerPadding { get; set; }

        public DockerShapeContext()
        {
            this.MenuItemButtonSize = new Size(48, 48);
            this.DockerPadding = 12;
        }
    }
}
