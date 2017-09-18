using System;
using System.Collections.Generic;

namespace ZeroRoo.Laundry15.Models
{
    public class LaundryTicket
    {
        public LaundryTicket()
        {
            this.ClotheRecords = new List<TicketClotheRecord>();
        }

        public int ID { get; set; }

        public string IDView { get; set; }

        public int CustomerID { get; set; }
        public UserProfile Customer { get; set; }

        public bool HasPay { get; set; }

        public FeeRecord FeeRecord { get; set; }

        /// <summary>
        /// 是否已经取回
        /// </summary>
        public bool HasTakeOff { get; set; }

        public DateTime RealTakeAwayAt { get; set; }

        public ClotheWayType GetClotheWay { get; set; }

        public ClotheWayType TakeOffClotheWay { get; set; }

        public DateTime PlanTakeAwayAt { get; set; }

        public string Mark { get; set; }

        public IList<TicketClotheRecord> ClotheRecords { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
