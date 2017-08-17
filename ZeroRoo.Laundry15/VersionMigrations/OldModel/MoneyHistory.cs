using System;

namespace Laundry.DbMigration
{
    public class MoneyHistory
    {
        public string MoneyID { get; set; }

        public string UserID { get; set; }

        public string UserName { get; set; }

        public double ShiShouMoney { get; set; }        //实际收入

        public double ZengSongMoney { get; set; }       //赠送

        public double BeforeMoney { get; set; }         //充值前

        public double Money { get; set; }               //现在余额

        public DateTime MoneyTime { get; set; }         //充值时间

        public string BeiZhu { get; set; }

    }
}
