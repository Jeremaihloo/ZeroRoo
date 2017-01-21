using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Apps.Laundry
{
    public partial class TestForm : Form, IActivity
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public void OnActive()
        {
            throw new NotImplementedException();
        }

        public void OnCreate()
        {
            this.Show();
        }
    }
}
