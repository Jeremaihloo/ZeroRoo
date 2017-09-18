using System;

namespace ZeroRoo.Laundry15.Models
{
    /// <summary>
    /// 顾客消费记录
    /// </summary>
    public class FeeRecord
    {

        public int ID { get; set; }

        public string IDView { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        public decimal Account { get; set; }

        /// <summary>
        /// 赠送金额
        /// </summary>
        public decimal RealAccount { get; set; }

        /// <summary>
        /// 赠送金额
        /// </summary>
        public decimal GiftAccount { get; set; }

        /// <summary>
        /// 使用现金支付的金额
        /// </summary>
        public decimal FromCash { get; set; }

        /// <summary>
        /// 使用Vip充值余额
        /// </summary>
        public decimal FromVip { get; set; }

        /// <summary>
        /// 消费记录之前的用户余额
        /// </summary>
        public decimal BeforeUserBlance { get; set; }

        /// <summary>
        /// 消费后账户余额
        /// </summary>
        public decimal AfterUserBlance { get; set; }


        //public LaundryTicket Ticket { get; set; }
        public int TicketID { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        public FeeType FeeType { get; set; }

        public string Mark { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        /// <value>The type of the pay.</value>
        public PayType PayType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int CustomerID { get; set; }
        public UserProfile Customer { get; set; }


        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

    }
}
