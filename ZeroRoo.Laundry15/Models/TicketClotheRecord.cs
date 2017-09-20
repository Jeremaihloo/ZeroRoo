using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZeroRoo.Laundry15.Models
{
    public class TicketClotheRecord
    {
        [Description("编号")]
        public int ID { get; set; }

        [Description("名称")]
        public string Name { get; set; }

        [Description("颜色")]
        public string Color { get; set; }

        [Description("状态")]
        public TicketClotheState State { get; set; }

        [Description("位置")]
        public string Loacation { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [Description("品牌")]
        public string Brand { get; set; }

        [Description("价格")]
        public decimal Price { get; set; }

        public List<FlawRecord> FlawRecords { get; set; }

        [Description("备注")]
        public string Mark { get; set; }

        public int LaundryTicketID { get; set; }
        public LaundryTicket LaundryTicket { get; set; }

        /// <summary>
        /// 是否参与折扣
        /// </summary>
        [Description("是否参与折扣")]
        public bool IsDiscount { get; set; }

        [Description("折扣")]
        public decimal Discount { get; set; }

        [Description("实际取走时间")]
        public DateTime RealTakeOffAt { get; set; }

        [Description("创建时间")]
        public DateTime CreateAt { get; set; }

        [Description("更新时间")]
        public DateTime UpdateAt { get; set; }
    }
}
