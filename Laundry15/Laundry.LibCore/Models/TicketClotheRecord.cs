using System;
using System.Collections.Generic;

namespace Laundry.LibCore.Models
{
    public enum TicketClotheState
    {
        NotClean = 0,
        HasClean = 1,
        TakeOff = 2
    }
    
    public class TicketClotheRecord
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public TicketClotheState State { get; set; }

        public string Loacation { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }

        public decimal Price { get; set; }
        
        public List<FlawRecord> FlawRecords { get; set; }

        public string Mark { get; set; }

        public int LaundryTicketID { get; set; }
        public LaundryTicket LaundryTicket { get; set; }

        /// <summary>
        /// 是否参与折扣
        /// </summary>
        public bool IsDiscount { get; set; }

        public decimal Discount { get; set; }

        public DateTime RealTakeOffAt { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
