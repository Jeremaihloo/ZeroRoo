using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q.Controls;

namespace ZeroRoo.Docker.Shapes
{
    public class MenuItemContainer : QPanel, IShapeContainer
    {
        private DockerShapeContext context;
        public MenuItemContainer(DockerShapeContext context)
        {
            this.context = context;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            RangeButtons();
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            RangeButtons();
        }

        void RangeButtons()
        {
            this.Width = this.Controls.Count * context.MenuItemButtonSize.Width +
                    (this.Controls.Count + 1) * context.DockerPadding;
            this.Height = context.DockerPadding * 2 + context.MenuItemButtonSize.Height;
            this.Left = context.DockerPadding;

            if (this.Parent != null)
            {
                this.Parent.Width = this.Width;
                this.Parent.Height = this.Height;
            }

            for (var i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Location = new Point(i * context.MenuItemButtonSize.Width + (i + 1) * context.DockerPadding,
                    context.DockerPadding);
            }
        }

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
