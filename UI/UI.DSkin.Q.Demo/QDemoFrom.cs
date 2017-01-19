using DSkin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Q.Demo
{
    public partial class QDemoFrom : QForm
    {
        public QDemoFrom()
        {
            InitializeComponent();

            Q.Forms.QToolTipForm.NewBind(this.qBigButton2);
        }

        private void blueButton1_Click(object sender, EventArgs e)
        {

        }

        private void qButton1_Click(object sender, EventArgs e)
        {
            var result = QMessageBox.Show(this, "测试收费记录数控刀具发生的纠纷几时放假老师介绍的发生萨芬撒撒的", "信息", MessageBoxButtons.YesNoCancel);
            QMessageBox.Show(this, result.ToString(), "结果");
        }

        private void qBigButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void qBigButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
