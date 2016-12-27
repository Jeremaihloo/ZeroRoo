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

namespace Laundry.LibCore.Forms
{
    public partial class FlawSelectForm : QForm
    {
        public FlawSelectForm()
        {
            InitializeComponent();
        }
        private List<Flaw> list = new List<Flaw>();

        private FlawRepository repository = new FlawRepository();

        private List<FlawRecord> recordList = new List<FlawRecord>();
        
        public static List<FlawRecord> FlawRecordList { get; set; }

        private void 选择瑕疵_Load(object sender, EventArgs e)
        {
            this.list = repository.List();
            this.lvFlaw.Columns.Add("瑕疵内容", this.lvFlaw.Width - 30);
            foreach(var item in this.list)
            {
                var lvItem = new ListViewItem(item.Text);
                this.lvFlaw.Items.Add(lvItem);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.recordList = new List<FlawRecord>();
            foreach(var item in this.lvFlaw.CheckedItems)
            { 
                var record = new FlawRecord();
                record.Text = this.list[((ListViewItem)item).Index].Text;
                this.recordList.Add(record);
            }
            FlawRecordList = this.recordList;
            this.Close();
        }
    }
}
