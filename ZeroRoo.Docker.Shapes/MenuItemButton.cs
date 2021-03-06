﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroRoo.Docker.Shapes
{
    public class MenuItemButton: IShape
    {
        public string Text { get; set; }
        public string Name { get; set; }
        public object Tag { get; set; }
        public Size Size { get; set; }

        public event EventHandler Click;
    }
}
