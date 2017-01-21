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
using Laundry.LibCore.Forms;
using Laundry.LibCore.Models;
using Laundry.LibCore;
using Laundry.LibCore.Print;
using Laundry.LibCore.Print.Templates;
using UI.Q;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Apps.Laundry
{
    public partial class LaundryTicketForm : QForm, IActivity
    {
        public LaundryTicketForm()
        {
            InitializeComponent();
        }
        
        LaundryTicket ticket = new LaundryTicket();

        LaundryRepository laundryRepository = new LaundryRepository();
        VipRepository vipRepository = new VipRepository();

        private bool Saved = false;

        private void LaundryTicket_Load(object sender, EventArgs e)
        {
            this.cbGetClotheWay.Items.AddRange(new DSkin.DirectUI.DuiLabel[] 
            {
                new DSkin.DirectUI.DuiLabel() { Text = "自己", TextAlign = ContentAlignment.MiddleCenter, Height = this.cbGetClotheWay.Height },
                new DSkin.DirectUI.DuiLabel() {Text = "上门", TextAlign = ContentAlignment.MiddleCenter , Height = this.cbGetClotheWay.Height }
            });
            this.cbTakeOffWay.Items.AddRange(new DSkin.DirectUI.DuiLabel[]
            {
                new DSkin.DirectUI.DuiLabel() { Text = "自己", TextAlign = ContentAlignment.MiddleCenter , Height = this.cbTakeOffWay.Height },
                new DSkin.DirectUI.DuiLabel() {Text = "上门", TextAlign = ContentAlignment.MiddleCenter  , Height = this.cbTakeOffWay.Height }
            });

            this.txtGender.Items.AddRange(new DSkin.DirectUI.DuiLabel[]
            {
                new DSkin.DirectUI.DuiLabel() { Text = "女", TextAlign = ContentAlignment.MiddleCenter , Height = this.txtGender.Height },
                new DSkin.DirectUI.DuiLabel() {Text = "男", TextAlign = ContentAlignment.MiddleCenter , Height = this.txtGender.Height }
            });
        }

        private void BindClothes()
        {
            this.glClothe.Rows.Clear();
            foreach (var item in ticket.ClotheRecords)
            {
                DSkin.Controls.DSkinGridListRow lvi = new DSkin.Controls.DSkinGridListRow();
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Name });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Price.ToString() });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Color });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Brand });
                var flaw = item.FlawRecords.Select(h => h.Text).ToArray();
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = string.Join(",", flaw) });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Mark });
                lvi.Tag = item;
                this.glClothe.Rows.Add(lvi);
            }
        }

        private void btnAddClothe_Click(object sender, EventArgs e)
        {
            TicketClotheForm.Result = null;
            TicketClotheForm form = new TicketClotheForm();
            form.ShowDialog();
            if (TicketClotheForm.Result != null)
            {
                var ticketClothe = new TicketClotheRecord();
                ticketClothe = TicketClotheForm.Result;
                this.ticket.ClotheRecords.Add(ticketClothe);
                this.BindClothes();
            }

        }

        private void btnClothe_Click(object sender, EventArgs e)
        {
            this.tab.SelectedIndex = 0;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.tab.SelectedIndex = 1;
            this.txtThisMoney.Text = FeeCalculator.New().Calculate(this.ticket).ToString();
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            if (this.checkIsFinish())
            {
                this.tab.SelectedIndex = 2;

                this.txtThisMoney.Text = FeeCalculator.New().Calculate(this.ticket).ToString();

                this.ticketViewBox.SetTicket(this.ticket);
            }
        }

        bool checkIsFinish()
        {
            if (this.ticket == null)
            {
                QMessageBox.Show("衣单为空！");
                return false;
            }

            // 衣服数量   
            if (this.ticket.ClotheRecords.Count == 0)
            {
                QMessageBox.Show("没有填写任何衣服！");
                return false;
            }

            // 用户（姓名，手机号码）
            if (this.ticket.Vip == null)
            {
                QMessageBox.Show("顾客信息填写不完整！");
                return false;
            }
            if(string.IsNullOrEmpty(this.ticket.Vip.Name))
            {
                QMessageBox.Show("顾客姓名没有填写！");
                return false;
            }
            if(string.IsNullOrEmpty(this.ticket.Vip.Phone))
            {
                QMessageBox.Show("顾客手机没有填写！");
                return false;
            }
            // 衣单（取衣时间）
            if (this.ticket.PlanTakeAwayAt == default(DateTime) || this.ticket.PlanTakeAwayAt.Date == DateTime.Now.Date)
            {
                QMessageBox.Show("取衣时间没有正确设置！");
                return false;
            }
            
            return true;
        }

        private void btnEditClothe_Click(object sender, EventArgs e)
        {
            if (this.glClothe.SelectedItem == null)
            {
                QMessageBox.Show("请选择一个衣服进行编辑！");
                return;
            }

            TicketClotheForm.Result = null;
            TicketClotheForm form = new TicketClotheForm();
            form.Set(this.glClothe.SelectedItem.Tag as TicketClotheRecord);
            form.ShowDialog();
            if (TicketClotheForm.Result != null)
            {
                var ticketClothe = new TicketClotheRecord();
                ticketClothe = TicketClotheForm.Result;
                this.glClothe.SelectedItem.Tag = ticketClothe;
                this.BindClothes();
            }
        }

        private void lvClothe_DoubleClick(object sender, EventArgs e)
        {
            TicketClotheForm.Result = null;
            TicketClotheForm form = new TicketClotheForm();
            form.Set(this.ticket.ClotheRecords[(int)this.glClothe.SelectedItem.Tag]);
            form.ShowDialog();
            if (TicketClotheForm.Result != null)
            {
                var ticketClothe = new TicketClotheRecord();
                ticketClothe = TicketClotheForm.Result;
                this.ticket.ClotheRecords[(int)this.glClothe.SelectedItem.Tag] = ticketClothe;
                this.BindClothes();
            }
        }

        private void btnDeleteClothe_Click(object sender, EventArgs e)
        {
            if (this.glClothe.SelectedItems == null || this.glClothe.SelectedItems.Count == 0)
            {
                QMessageBox.Show("你必须要先选择一个衣服才能进行删除！");
                return;
            }
            this.ticket.ClotheRecords.Remove(this.glClothe.SelectedItem.Tag as TicketClotheRecord);
            this.BindClothes();
        }

        private void txtVipID_TextChanged(object sender, EventArgs e)
        {
            this.vip = this.vipRepository.List().Where(item => item.VipID == this.txtVipID.Text).FirstOrDefault();
            if (vip != null)
            {
                this.ticket.Vip = vip;

                this.bindVip();
            }
            
        }

        void bindVip()
        {
            this.txtVipID.Text = this.vip.VipID;
            this.txtName.Text = this.vip.Name;
            this.txtAddress.Text = this.vip.Address;
            this.txtPhone.Text = this.vip.Phone;
            this.txtGender.SelectedIndex = this.vip.Sex == "女" ? 0 : 1;
            this.txtBalance.Text = this.vip.Balance.ToString();
            var account = FeeCalculator.New().Calculate(ticket);
            this.txtThisMoney.Text = account.ToString();
            if (account > this.vip.Balance)
            {
                QMessageBox.Show("本次消费超过会员卡余额！请及时充值或用现金支付！");
            }
        }
        
        private Vip vip = null;

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            var user = this.vipRepository.List().FirstOrDefault(item => item.Phone == this.txtPhone.Text);
            if (user != null)
            {
                this.vip = user;

                this.bindVip();
            }
        }

        private void btnSaveTicket_Click(object sender, EventArgs e)
        {
            if (this.vip == null)
            {
                this.vip = new Vip();
                this.vip.Name = this.txtName.Text;
                this.vip.Address = this.txtAddress.Text;
                this.vip.Phone = this.txtPhone.Text;
                this.vip.Sex = this.txtGender.SelectedDuiControl.Text;

                this.vipRepository.Save(this.vip);
            }

            this.ticket.VipID = this.vip.ID;

            var ticketSave = new LaundryTicket();
            ticketSave.ClotheRecords = this.ticket.ClotheRecords;
            ticketSave.GetClotheWay = this.ticket.GetClotheWay;
            ticketSave.TakeOffClotheWay = this.ticket.TakeOffClotheWay;
            ticketSave.Mark = this.txtMark.Text;
            ticketSave.VipID = this.vip.ID;

            if (!this.Saved)
            {
                this.laundryRepository.Save(ticketSave);
            }
            else
            {
                this.laundryRepository.Update(ticketSave);
            }
            QMessageBox.Show("保存成功！");
        }

        private void btnPrintTicketView_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            TicketFeeForm form = new TicketFeeForm();
            form.SetTicket(this.ticket);
            form.ShowDialog();
        }

        private void dtpPlanTakeAt_ValueChanged(object sender, EventArgs e)
        {
            this.ticket.PlanTakeAwayAt = this.dtpPlanTakeOff.Value;
        }

        private void cbGetClotheWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ticket.GetClotheWay = (ClotheWayType)this.cbGetClotheWay.SelectedIndex;
        }

        private void cbTakeOffWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ticket.TakeOffClotheWay = (ClotheWayType)this.cbTakeOffWay.SelectedIndex;
        }

        private void txtMark_TextChanged(object sender, EventArgs e)
        {
            this.ticket.Mark = this.txtMark.Text;
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tab.SelectedIndex == 2)
            {
                if (this.checkIsFinish())
                {
                    this.tab.SelectedIndex = 2;

                    this.txtThisMoney.Text = FeeCalculator.New().Calculate(this.ticket).ToString();

                    this.ticketViewBox.SetTicket(this.ticket);
                }
                else
                {
                    this.tab.SelectedIndex = 0;
                }
            }
            if(this.tab.SelectedIndex == 1)
            {
                this.txtThisMoney.Text = FeeCalculator.New().Calculate(this.ticket).ToString();
            }
        }

        public void OnActive()
        {
            
        }

        public void OnCreate()
        {
            this.Show();
        }
    }
}
