using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Q.Core;

namespace UI.Q.Controls
{
    public class QKeySelectorBar: QFlowLayoutPanel
    {
        private Size keyButtonSize;
        public Size KeyButtonSize
        {
            get
            {
                return keyButtonSize;
            }
            set
            {
                keyButtonSize = value;
                this.bindKeys();
            }
        }

        private string[] keys;
        public string[] Keys
        {
            get
            {
                return keys;
            }
            set
            {
                keys = value;
                this.bindKeys();
            }
        }

        public event SelectKeyChangedHandler SelectKeyChanged;

        public QKeySelectorBar()
            : base()
        {
            this.Keys = new string[]
            {
                "A","B","C","D","E","F","G",
                "H","I","J","K","L","M","N",
                "O","P","Q","R","S","T",
                "U","V","W","X","Y","Z"
            };

            this.KeyButtonSize = new Size(18, 18);
        }

        private void bindKeys()
        {
            this.Controls.Clear();

            foreach(var item in this.Keys)
            {
                QButton btn = new QButton();
                btn.Size = this.KeyButtonSize;
                btn.Text = item.ToString();
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.SelectKeyChanged?.Invoke(this, new SelectKeyChangedEventArgs((sender as QButton).Text));
        }
    }
}
