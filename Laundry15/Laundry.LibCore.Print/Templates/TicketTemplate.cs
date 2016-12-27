using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laundry.LibCore.Models;
using ZeroRoo.Configuration;

namespace Laundry.LibCore.Print.Templates
{
    public class TicketTemplate : IPrintTemplate
    {
        public LaundryTicket Ticket { get; set; }

        public TicketTemplate(LaundryTicket ticket)
        {
            this.Ticket = ticket;
            this.storeInfo = ConfigManager.Default.Config<Store>();
        }

        private Store storeInfo;

        public List<PrintLine> GetLines()
        {
            List<PrintLine> lines = new List<PrintLine>();

            lines.Add(new PrintLine("美国UCC国际洗衣", 8, StringAlignment.Center));
            lines.Add(new PrintLine("--------------------------------------------------", 8));
            lines.Add(new PrintLine("取衣凭据", 10, StringAlignment.Center));
            lines.Add(new PrintLine("取衣单号：" + this.Ticket.IDView, 12));
            lines.Add(new PrintLine("取衣时间：" + this.Ticket.PlanTakeAwayAt.ToString("yyyy年MM月dd日"), 10));
            lines.Add(new PrintLine("收衣时间：" + this.Ticket.CreateAt.ToString("yyyy年MM月dd日"), 10));
            lines.Add(new PrintLine("衣物件数：" + this.Ticket.ClotheRecords.Count, 10));
            lines.Add(new PrintLine("--------------------------------------------------", 10));
            lines.Add(new PrintLine("顾客签字：_____________", 12));
            lines.Add(new PrintLine("--------------------------------------------------", 10));


            for (int i = 0; i < this.Ticket.ClotheRecords.Count; i++)
            {
                var item = this.Ticket.ClotheRecords[i];
                lines.Add(new PrintLine("编号：" + item.ID, 8));
                lines.Add(new PrintLine("衣物：" + item.Name + "  价格：" + item.Price, 8));
                lines.Add(new PrintLine("颜色：" + item.Color + "  品牌：" + item.Brand, 8));
                //lines.Add(new PrintLine(YiFuList[i].ClotheID + " " + YiFuList[i].ClotheType + " " + YiFuList[i].Price + " " + YiFuList[i].Color + " " + YiFuList[i].PinPai, 8));

                lines.Add(new PrintLine("瑕疵：", 8));
                var flawList = new List<string>();
                foreach(var flaw in item.FlawRecords)
                {
                    flawList.Add(flaw.Text);
                }

                for(var j =0;j<flawList.Count;j++)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int k = j; k < j + 3; k++)
                    {
                        if (k < flawList.Count)
                            if (!string.IsNullOrEmpty(flawList[k]))
                                sb.Append(flawList[k] + "  ");
                    }
                    lines.Add(new PrintLine(sb.ToString(), 8));
                }

                if (!string.IsNullOrEmpty(item.Mark))
                {
                    lines.Add(new PrintLine("备注：" + item.Mark, 8));
                }
                lines.Add(new PrintLine("                                      ", 8));
            }

            lines.Add(new PrintLine("-------------------------------------------", 8));

            if (!string.IsNullOrEmpty(this.Ticket.Mark))
            {
                lines.Add(new PrintLine("备注：" + this.Ticket.Mark, 8));
                lines.Add(new PrintLine("                                        ", 8));
            }

            lines.Add(new PrintLine("--------------------------------------------------", 8));
            lines.Add(new PrintLine("总计金额：" + FeeCalculator.New().Calculate(this.Ticket), 14));
            lines.Add(new PrintLine("付款状态：" + this.Ticket.HasPay, 10));
            lines.Add(new PrintLine("                                        ", 8));
            lines.Add(new PrintLine("卡上余额：" + this.Ticket.Vip.Balance + "元", 12));

            lines.Add(new PrintLine("仿皮、皮草、地毯、单烫等不打折", 8));
            lines.Add(new PrintLine("本店地址: " + this.storeInfo.Address, 8));
            lines.Add(new PrintLine("服务热线：" + this.storeInfo.Phone, 8));
            lines.Add(new PrintLine("打印日期：" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm"), 8));
            lines.Add(new PrintLine("==================================================", 8));
            lines.Add(new PrintLine("凭单取衣", 8, StringAlignment.Center));
            lines.Add(new PrintLine("欢迎您的光临", 8, StringAlignment.Center));
            lines.Add(new PrintLine("衣服出门本店概不负责", 8, StringAlignment.Center));
            lines.Add(new PrintLine("保管期超过一个月另收保管费", 8, StringAlignment.Center));
            lines.Add(new PrintLine("关注本店官方微信，获取更多优惠资讯", 8, StringAlignment.Center));

            return lines;
        }
    }
}
