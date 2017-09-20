using System;
using System.ComponentModel;

namespace ZeroRoo.Laundry15.Models
{
    /// <summary>
    /// 顾客消费记录
    /// </summary>
    public class FeeRecord
    {

        [Description("编号")]
        public int ID { get; set; }

        [Description("消费编号")]
        public string IDView { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        [Description("消费金额")]
        public decimal Account { get; set; }

        /// <summary>
        /// 实际金额
        /// </summary>
        [Description("实际金额")]
        public decimal RealAccount { get; set; }

        /// <summary>
        /// 赠送金额
        /// </summary>
        [Description("赠送金额")]
        public decimal GiftAccount { get; set; }

        /// <summary>
        /// 使用现金支付的金额
        /// </summary>
        [Description("使用现金支付的金额")]
        public decimal FromCash { get; set; }

        /// <summary>
        /// 使用Vip充值余额
        /// </summary>
        [Description("使用Vip余额支付的金额")]
        public decimal FromVip { get; set; }

        /// <summary>
        /// 消费记录之前的用户余额
        /// </summary>
        [Description("消费记录之前的用户余额")]
        public decimal BeforeUserBlance { get; set; }

        /// <summary>
        /// 消费后账户余额
        /// </summary>
        [Description("消费后账户余额")]
        public decimal AfterUserBlance { get; set; }


        public LaundryTicket Ticket { get; set; }
        public int TicketID { get; set; }

        /// <summary>
        /// 消费类型
        /// </summary>
        [Description("消费类型")]
        public FeeType FeeType { get; set; }

        [Description("备注")]
        public string Mark { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        /// <value>The type of the pay.</value>
        [Description("支付方式")]
        public PayType PayType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int CustomerID { get; set; }
        public UserProfile Customer { get; set; }

        [Description("创建时间")]
        public DateTime CreateAt { get; set; }

        [Description("更新时间")]
        public DateTime UpdateAt { get; set; }

    }
}
