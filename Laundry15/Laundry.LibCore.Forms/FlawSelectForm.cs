using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry.LibCore.Repository;
using Laundry.LibCore.Models;
using UI.Q;
using UI.Q.Forms;
using DSkin.DirectUI;
using ZeroRoo.Utils;

namespace Laundry.LibCore.Forms
{
    public partial class FlawSelectForm : QSelectorForm
    {
        public FlawSelectForm()
        {
            InitializeComponent();

            this.KeySelectorBar.SelectKeyChanged += KeySelectorBar_SelectKeyChanged;
        }

        private void KeySelectorBar_SelectKeyChanged(object sender, UI.Q.Core.SelectKeyChangedEventArgs e)
        {
            PinYinBuilder builder = new PinYinBuilder();

            var list = this.list
                .Where(item => item.Text.Length > 0)
                .Where(item => builder.GetHanz2PinYinFirst(item.Text[0]) == e.Char)
                .ToArray();

            this.Bind(list);
        }

        private List<Flaw> list = new List<Flaw>();

        private FlawRepository repository = new FlawRepository();

        private List<FlawRecord> recordList = new List<FlawRecord>();
        
        public static List<FlawRecord> FlawRecordList { get; set; }

        private List<DuiCheckBox> CachedCheckBox = new List<DuiCheckBox>();

        private void 选择瑕疵_Load(object sender, EventArgs e)
        {
            this.list = repository.List();

            this.Bind(this.list.ToArray());
        }

        private void Bind(Flaw[] datas)
        {
            this.SelectDataListBox.Items.Clear();
            foreach(var item in datas)
            {
                var cache = this.CachedCheckBox.FirstOrDefault(h => h.Text == item.Text);
                if (cache == null)
                {
                    var label = new DuiCheckBox();
                    label.Width = this.Width;
                    label.Height = 25;
                    label.Text = item.Text;
                    label.Tag = item;
                    label.MouseEnter += Label_MouseEnter;
                    label.MouseLeave += Label_MouseLeave;
                    label.CheckedChanged += Label_CheckedChanged;
                    this.CachedCheckBox.Add(label);
                    this.SelectDataListBox.Items.Add(label);

                }
                else
                {
                    this.SelectDataListBox.Items.Add(cache);
                }
            }
        }

        private void Label_CheckedChanged(object sender, EventArgs e)
        {
            var box = (DuiCheckBox)sender;
            if (!box.Checked)
            {
                var cache = this.CachedCheckBox.FirstOrDefault(h => h.Text == box.Text);
                this.CachedCheckBox.Remove(cache);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (FlawRecordList == null)
                FlawRecordList = new List<FlawRecord>();

            foreach(var item in this.CachedCheckBox)
            {
                var c = (DuiCheckBox)item;
                if (c.Checked)
                {
                    if (!FlawRecordList.Any(h => h.Text == c.Text))
                        FlawRecordList.Add(new FlawRecord() { Text = (c.Tag as Flaw).Text });
                }
            }
            base.OnFormClosing(e);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            ((DuiCheckBox)sender).BackColor = System.Drawing.Color.Transparent;
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            ((DuiCheckBox)sender).BackColor = System.Drawing.Color.FromArgb(120, 252, 240, 193);
        }

    }
}
