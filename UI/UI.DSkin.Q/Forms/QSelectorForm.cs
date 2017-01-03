using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q.Controls;
using UI.Q.Core;

namespace UI.Q.Forms
{
    public partial class QSelectorForm : QForm
    {
        public QKeySelectorBar KeySelectorBar
        {
            get
            {
                return this.keySelectBar;
            }
        }

        public QListBox SelectDataListBox
        {
            get
            {
                return this.lvSelectData;
            }
        }

        public QTextBox SearchTextBox
        {
            get
            {
                return this.txtSearch;
            }
        }

        public QSelectorForm()
        {
            InitializeComponent();
        }
    }
}
