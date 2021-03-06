using System;

namespace Laundry.LibCore.Models
{
    /// <summary>
    /// 衣服瑕疵
    /// </summary>

    public class FlawRecord
    {
        public int ID { get; set; }

        public string Text { get; set; }

        public int TicketClotheRecordID { get; set; }
        public TicketClotheRecord TicketClotheRecord { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
