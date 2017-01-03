using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DSkin.Controls;
using DSkin.DirectUI;
using DSkin.Forms;
using ZeroRoo.Docker.Properties;
using ZeroRoo.App;
using UI.Q;

namespace ZeroRoo.Docker
{
    public partial class Dashboard : DSkinForm
    {
        public int deltop = 32;
        public int MaxWidth = 80;
        public int MaxHeight = 80;
        public int MinWidth = 40;
        public int MinHeight = 40;
        public int ChangeSize = 4;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void DBMouseClick(object sender, EventArgs e)
        {

            //try
            //{
                int up1 = 1;
                int down1 = 1;
                int up2 = 1;
                int down2 = 1;
                //bool upok = false;
                //bool dowmok = false;
                DoEffect(() =>
                {

                    if (down1 < 15)
                    {
                        //Thread.Sleep(30);
                        ((DuiBaseControl)sender).Top += 1;
                        down1 += 1;
                        return true;
                    }
                    if (up1 < 15)
                    {
                        //Thread.Sleep(30);
                        ((DuiBaseControl)sender).Top -= 1;
                        up1 += 1;
                        return true;
                    }
                    if (up2 < 15)
                    {
                        //Thread.Sleep(70);
                        ((DuiBaseControl)sender).Top += 1;
                        up2 += 1;
                        return true;
                    }
                    if (down2 < 15)
                    {
                        //Thread.Sleep(70);
                        ((DuiBaseControl)sender).Top -= 1;
                        down2 += 1;
                        return true;
                    }
                    return false;
                });
            //}
            //catch
            //{
            //}

            try
            {
                this.appProcessManager.Start(((DuiBaseControl)sender).Tag.ToString());
            }
            catch(Exception ex)
            {
                QMessageBox.Show(ex.Message, "错误");
            }

        }

        private int getIndex(DuiBaseControl control)
        {
            for(var i=0;i<this.appLoader.AppManageItems.Count;i++)
            {
                if(this.appLoader.AppManageItems[i].Config.ID == control.Tag.ToString())
                {
                    return i;
                }
            }
            return -1;
        }

        private void DBMouseEnter(object sender, EventArgs e)
        {
            //try
            //{
            int index = this.getIndex(sender as DuiBaseControl);
                dSkinListBox1.Items[index].Tag = "0";
                DoEffect(() =>
                {
                    if (dSkinListBox1.Items.Count == 0)
                    {
                        return false;
                    }
                    if (dSkinListBox1.Items[index].Tag.ToString() == "1")
                    {
                        return false;
                    }
                    if (dSkinListBox1.Items[index].Width < MaxWidth)
                    {
                        int _changeSize = MaxWidth - dSkinListBox1.Items[index].Width >= ChangeSize ? ChangeSize : MaxWidth - dSkinListBox1.Items[index].Width;
                        dSkinListBox1.Items[index].Width += _changeSize;
                        ((DuiBaseControl)sender).Width += _changeSize;
                        ((DuiBaseControl)sender).Height += _changeSize;
                        ((DuiBaseControl)sender).Location =
                            new Point((dSkinListBox1.Items[index].Width - ((DuiBaseControl)sender).Width) / 2,
                                ((dSkinListBox1.Items[index].Height - ((DuiBaseControl)sender).Height - deltop)));

                        dSkinListBox1.LayoutContent();
                        changesize();
                        return true;
                    }
                    dSkinListBox1.Items[index].Width = MaxWidth;
                    ((DuiBaseControl)sender).Width = MaxWidth;
                    ((DuiBaseControl)sender).Height = MaxHeight;
                    ((DuiBaseControl)sender).Location =
                        new Point((dSkinListBox1.Items[index].Width - ((DuiBaseControl)sender).Width) / 2,
                            ((dSkinListBox1.Items[index].Height - ((DuiBaseControl)sender).Height - deltop)));
                    dSkinListBox1.LayoutContent();
                    changesize();
                    return false;
                });
            //}
            //catch
            //{
            //}
        }
        private void DBMouseLeave(object sender, EventArgs e)
        {
            //try
            //{
            int index = this.getIndex(sender as DuiBaseControl);
                dSkinListBox1.Items[index].Tag = "1";
                DoEffect(() =>
                {
                    if (dSkinListBox1.Items.Count == 0)
                    {
                        return false;
                    }
                    if (dSkinListBox1.Items[index].Tag.ToString() == "0")
                    {
                        return false;
                    }
                    if (dSkinListBox1.Items[index].Width > MinWidth)
                    {
                        int _changeSize = (dSkinListBox1.Items[index].Width - MinWidth) >= ChangeSize
                            ? ChangeSize
                            : dSkinListBox1.Items[index].Width - MinWidth;
                        dSkinListBox1.Items[index].Width -= _changeSize;
                        ((DuiBaseControl)sender).Width -= _changeSize;
                        ((DuiBaseControl)sender).Height -= _changeSize;
                        ((DuiBaseControl)sender).Location =
                            new Point((dSkinListBox1.Items[index].Width - ((DuiBaseControl)sender).Width) / 2,
                                (dSkinListBox1.Items[index].Height - ((DuiBaseControl)sender).Height - deltop));
                        dSkinListBox1.LayoutContent();
                        changesize();
                        return true;
                    }
                    dSkinListBox1.Items[index].Width = MinWidth;
                    ((DuiBaseControl)sender).Width = MinWidth;
                    ((DuiBaseControl)sender).Height = MinHeight;
                    ((DuiBaseControl)sender).Location =
                        new Point((dSkinListBox1.Items[index].Width - ((DuiBaseControl)sender).Width) / 2,
                            (dSkinListBox1.Items[index].Height - ((DuiBaseControl)sender).Height - deltop));
                    dSkinListBox1.LayoutContent();
                    changesize();

                    return false;
                });
            //}
            //catch
            //{
            //}
        }

        public void changesize()
        {
            int w = 0;
            for (int i = 0; i < dSkinListBox1.Items.Count; i++)
            {
                w += dSkinListBox1.Items[i].Width;
            }
            dSkinListBox1.Width = w + 15;
            duiBaseControl1.Width = w + 50;
            dSkinListBox1.Left = (Screen.PrimaryScreen.Bounds.Width - w) / 2 + 20;
            duiBaseControl1.Left = (Screen.PrimaryScreen.Bounds.Width - w) / 2;
        }

        private void dSkinButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoveFormMouseDown(object sender, MouseEventArgs e)
        {
            #region 拖动无边框窗体
            // DSkin.NativeMethods.MouseToMoveControl(this.Handle);
            #endregion
        }

        private void FrmAppleButton_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            this.LoadApp();

            dSkinListBox1.LayoutContent();

            changesize();
            duiBaseControl1.MouseDown += MoveFormMouseDown;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SpeedChange(object sender, EventArgs e)
        {
            int _size = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());
            switch (_size)
            {
                case 0:
                    ChangeSize = (MaxWidth - MinWidth) / 2;
                    break;
                default:
                    ChangeSize = _size;
                    break;
            }
        }

        private void duiBaseControl1_MouseDown(object sender, DuiMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dSkinContextMenuStrip1.Show(this.Location.X + duiBaseControl1.Left + e.X, this.Location.Y + duiBaseControl1.Top + e.Y);
            }
        }

        AppLoader appLoader = new AppLoader();
        AppProcessManager appProcessManager;

        void LoadApp()
        {
            this.appLoader.Load();

            this.appProcessManager = new AppProcessManager(this.appLoader);

            this.appProcessManager.AutoStartApps();

            for (var i = 0; i < this.appLoader.AppManageItems.Count; i++)
            {
                DuiBaseControl dbf = new DuiBaseControl();
                dbf.Size = new Size(MinWidth, 140);
                DuiBaseControl db = new DuiBaseControl();
                db.Size = new Size(MinWidth, MinHeight);
                db.BackgroundImage = this.appLoader.AppManageItems[i].Icon;
                db.BackgroundImageLayout = ImageLayout.Zoom;
                db.Location = new Point((dbf.Width - MinWidth) / 2, (dbf.Height - MinHeight - deltop));
                db.MouseEnter += DBMouseEnter;
                db.MouseLeave += DBMouseLeave;
                db.MouseClick += DBMouseClick;
                db.Tag = this.appLoader.AppManageItems[i].Config.ID;
                dbf.Controls.Add(db);
                dSkinListBox1.Items.Add(dbf);
            }
            //this.Width = this.appManager.AppManageItems.Count * MaxWidth;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var index = btn.Tag.ToString();
            try
            {
                this.appProcessManager.Start(index);
            }
            catch(Exception ex)
            {
                QMessageBox.Show(ex.Message, "错误");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (MessageBox.Show("关闭系统前请确定你所有的工作都已经保存！\n点击【确定】退出系统，点击【取消】继续您的工作", "警告", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void dSkinListBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
