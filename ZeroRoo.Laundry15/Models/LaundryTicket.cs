using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ZeroRoo.Laundry15.Models
{
    public class LaundryTicket
    {
        public LaundryTicket()
        {
            this.ClotheRecords = new List<TicketClotheRecord>();
        }

        [Description("编号")]
        public int ID { get; set; }

        [Description("衣单编号")]
        public string IDView { get; set; }

        public int CustomerID { get; set; }
        public UserProfile Customer { get; set; }

        [Description("是否已付")]
        public bool HasPay { get; set; }

        public FeeRecord FeeRecord { get; set; }

        /// <summary>
        /// 是否已经取回
        /// </summary>
        [Description("是否已经取回")]
        public bool HasTakeOff { get; set; }

        [Description("取走时间")]
        public DateTime RealTakeAwayAt { get; set; }

        [Description("收衣方式")]
        public ClotheWayType GetClotheWay { get; set; }

        [Description("取衣方式")]
        public ClotheWayType TakeOffClotheWay { get; set; }

        [Description("计划取衣时间")]
        public DateTime PlanTakeAwayAt { get; set; }

        [Description("备注")]
        public string Mark { get; set; }

        public IList<TicketClotheRecord> ClotheRecords { get; set; }

        [Description("创建时间")]
        public DateTime CreateAt { get; set; }

        [Description("更新时间")]
        public DateTime UpdateAt { get; set; }
    }
}
