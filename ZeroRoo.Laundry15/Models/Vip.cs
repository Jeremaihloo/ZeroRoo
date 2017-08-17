
using System;

namespace Laundry.LibCore.Models
{

    public class Vip
    {
        public int ID { get; set; }

        public string VipID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Sex { get; set; }

        public string Phone { get; set; }

        public decimal Balance { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        /// <summary>
        /// 累计消费
        /// </summary>
        public decimal FeeSum { get; set; }

        /// <summary>
        /// 衣单数量
        /// </summary>
        public int TicketCount { get; set; }

        /// <summary>
        /// 衣服数量
        /// </summary>
        public int ClotheCount { get; set; }
    }
}
