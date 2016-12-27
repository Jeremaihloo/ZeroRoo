using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DSkin.Controls;

namespace UI.Q
{
    public partial class QVirtualKeyboardForm : QForm
    {
        //需要操作的文本框
        private TextBox txt;
        private int X;
        private int Y;
        public QVirtualKeyboardForm(int x, int y, TextBox txt)
        {
            InitializeComponent();
            this.txt = txt;
            this.X = x;
            this.Y = y;
        }
        #region 窗体停用时
        private void QVirtualKeyboardForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 删除
        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length > 0)
            {
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
            }
        }
        #endregion

        #region 追加文本
        private void btn_Click(object sender, EventArgs e)
        {
            DSkinButton btn = (DSkinButton)sender;
            txt.AppendText(btn.Text);
        }
        #endregion

        #region 大小写变换
        Image Norml;
        Image Mouse;
        bool ToUpper = false;
        bool flag = false;
        private void btnCapsLock_Click(object sender, EventArgs e)
        {
            ToUpper = !ToUpper;
            flag = !flag;
            foreach (DSkinButton btn in this.Controls)
            {
                if (btn.Tag.ToString() == "2")
                {
                    btn.Text = ToUpper ? btn.Text.ToUpper() : btn.Text.ToLower();
                }
            }
            //if (flag)
            //{
            //    Norml = btnCapsLock.NormlBack;
            //    Mouse = btnCapsLock.MouseBack;
            //    btnCapsLock.NormlBack = btnCapsLock.DownBack;
            //    btnCapsLock.MouseBack = btnCapsLock.DownBack;
            //}
            //else
            //{
            //    btnCapsLock.NormlBack = Norml;
            //    btnCapsLock.MouseBack = Mouse;
            //}
        }
        #endregion

        #region 切换键
        Image Norml2;
        Image Mouse2;
        bool flag2 = false;
        private void btnShift_Click(object sender, EventArgs e)
        {
            ToUpper = !ToUpper;
            flag2 = !flag2;
            //变换大小写
            foreach (DSkinButton btn in this.Controls)
            {
                if (btn.Tag.ToString() == "2")
                {
                    btn.Text = ToUpper ? btn.Text.ToUpper() : btn.Text.ToLower();
                }
            }

            //变换数字与符号
            foreach (DSkinButton btn in this.Controls)
            {
                if (btn.Tag.ToString().Substring(0, 1) == "1")
                {
                    btn.Text = flag2 ? btn.Tag.ToString().Substring(1, 1) : btn.Tag.ToString().Substring(2);
                }
            }
            //if (flag2)
            //{
            //    Norml2 = btnShift.NormlBack;
            //    Mouse2 = btnShift.MouseBack;
            //    btnShift.NormlBack = btnShift.DownBack;
            //    btnShift.MouseBack = btnShift.DownBack;
            //}
            //else
            //{
            //    btnShift.NormlBack = Norml2;
            //    btnShift.MouseBack = Mouse2;
            //}
        }
        #endregion

        #region 窗体加载时
        private void PassKey_Load(object sender, EventArgs e)
        {
            this.Location = new Point(X, Y);
        }
        #endregion

    }
}
