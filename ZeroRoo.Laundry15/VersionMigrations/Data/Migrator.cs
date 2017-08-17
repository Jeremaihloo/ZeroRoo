using Laundry.LibCore;
using System;
using System.Collections.Generic;
using System.Linq;
using NLog;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.IO;
using ZeroRoo.Utils;

namespace Laundry.DbMigration
{
    public class Migrator
    {
        public Dictionary<string, Func<Exception>> Steps { get; set; }

        private OldDbContext oldDbContext;
        private LaundryDbContext newDbContext;

        public bool HasStarted { get; set; }

        public bool HasFinish
        {
            get
            {
                return this.StepIndex == this.StepCount;
            }
        }

        private int StepIndex = 0;

        public bool CanMigration
        {
            get
            {
                if (new SystemInfo().Debug)
                    return true;

                if (!File.Exists("migration.lock"))
                {
                    return true;
                }

                return false;
            }
        }

        public Migrator()
        {
            oldDbContext = new OldDbContext();
            newDbContext = new LaundryDbContext();

            this.Steps = new Dictionary<string, Func<Exception>>();
            this.Steps.Add("检查是否可以进行数据迁移工作", CheckCanMigration);
            this.Steps.Add("创建数据库", CreateDataBase);
            this.Steps.Add("处理会员数据", MigrationVips);
            this.Steps.Add("处理瑕疵数据", MigrationFlaws);
            this.Steps.Add("处理颜色数据", MigrationColors);
            this.Steps.Add("创建衣服分类", CreateClotheCategories);
            this.Steps.Add("处理价格数据", MigrationPrices);
            this.Steps.Add("处理品牌数据", MigrationBrands);
            this.Steps.Add("处理衣单数据", MirationTickets);
            this.Steps.Add("处理消费记录", MigrationFeeRecords);
            this.Steps.Add("处理衣服数据", MigrationTicketClotheRecords);
        }

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public event EventHandler<string> NewStep;
        
        public int StepCount { get { return this.Steps.ToList().Count; } }

        public Exception CreateDataBase()
        {
            try
            {
                logger.Info("创建数据库");
                DatabaseFacade d = new DatabaseFacade(newDbContext);
                d.Migrate();
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }
        
        Laundry.LibCore.Models.Vip emptyCustomer = new Laundry.LibCore.Models.Vip();

        public Exception MigrationVips()
        {
            try
            {
                emptyCustomer.Name = "未知";
                emptyCustomer.Address = "";
                emptyCustomer.Phone = "000";
                newDbContext.Vips.Add(emptyCustomer);
                newDbContext.SaveChanges();

                var oldUserList = oldDbContext.UCC_User.ToList();
                logger.Info("{0} 会员数据 被找到", oldUserList.Count);

                foreach (var item in oldUserList)
                {
                    var newItem = new Laundry.LibCore.Models.Vip();
                    newItem.Address = item.Address;
                    newItem.Balance = (decimal)item.Money;
                    newItem.VipID = item.UserID;
                    newItem.Name = item.UserName;
                    newItem.Phone = item.PhoneNo;
                    newItem.Sex = item.Sex;
                    newDbContext.Vips.Add(newItem);
                }
                newDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }
        
        public Exception MigrationFlaws()
        {
            try
            {
                var oldFlawList = oldDbContext.UCC_XiaCi.ToList();

                logger.Info("{0} 瑕疵数据 被找到", oldFlawList.Count);

                foreach (var item in oldFlawList)
                {
                    var newItem = new Laundry.LibCore.Models.Flaw();
                    newItem.Text = item.XiaCiContent;
                    newDbContext.Flaws.Add(newItem);
                }
                newDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }

        public Exception MigrationColors()
        {
            try
            {
                var oldColorList = oldDbContext.UCC_YanSe.ToList();
                logger.Info("{0} 颜色数据 被找到", oldColorList.Count);

                foreach (var item in oldColorList)
                {
                    var newItem = new Laundry.LibCore.Models.Color();
                    newItem.Text = item.YanSeName;
                    newDbContext.Colors.Add(newItem);
                }
                newDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }

        public Exception CreateClotheCategories()
        {
            try
            {
                var s = new string[] { "服饰类", "皮草类", "织补类", "鞋子类", "车饰类", "单烫类", "家纺类" };
                foreach (var item in s)
                {
                    var cate = new Laundry.LibCore.Models.ClotheCategory();
                    cate.Text = item;
                    newDbContext.ClotheCategories.Add(cate);
                }
                newDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }

        Laundry.LibCore.Models.ClotheCategory emptyCategory = new Laundry.LibCore.Models.ClotheCategory();

        public Exception MigrationPrices()
        {
            try
            {
                emptyCategory.Text = "未知";
                newDbContext.ClotheCategories.Add(emptyCategory);
                newDbContext.SaveChanges();
                var oldClotheInfoList = oldDbContext.UCC_YiFuPriceType.ToList();
                logger.Info("{0} 价格数据 被找到", oldClotheInfoList.Count);

                foreach (var item in oldClotheInfoList)
                {
                    var newItem = new Laundry.LibCore.Models.Price();
                    newItem.CanDiscount = true;
                    newItem.IsDiscount = item.IsZheKou == 1;
                    newItem.Category = newDbContext.ClotheCategories.Where(a => a.Text == item.Cat).FirstOrDefault();
                    if (newItem.Category == null)
                    {
                        newItem.Category = emptyCategory;
                    }
                    newItem.CreateAt = DateTime.Now;
                    newItem.NowDiscount = 1;
                    newItem.Name = item.YiFuName;
                    newItem.PriceString = item.Price;
                    newDbContext.Prices.Add(newItem);
                }
                newDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }

        public Exception MigrationBrands()
        {
            try
            {
                var oldBrandList = oldDbContext.UCC_PinPai.ToList();
                logger.Info("{0} 品牌数据 被找到", oldBrandList.Count);

                foreach (var item in oldBrandList)
                {
                    var newItem = new Laundry.LibCore.Models.Brand();
                    newItem.Text = item.PinPaiName;
                    newDbContext.Brands.Add(newItem);
                }
                newDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }

        public Exception MirationTickets()
        {
            try
            {
                var emptyTicket = new Laundry.LibCore.Models.LaundryTicket();
                emptyTicket.GetClotheWay = LibCore.Models.ClotheWayType.Self;
                emptyTicket.HasPay = false;
                emptyTicket.HasTakeOff = false;
                emptyTicket.PlanTakeAwayAt = DateTime.Now;
                emptyTicket.CreateAt = DateTime.Now;
                emptyTicket.Mark = "";
                emptyTicket.IDView = "";
                emptyTicket.Vip = emptyCustomer;

                if (!newDbContext.LaundryTickets.Any())
                {
                    newDbContext.LaundryTickets.Add(emptyTicket);
                    newDbContext.SaveChanges();

                    var oldTicketList = oldDbContext.UCC_ShouYi.ToList();
                    logger.Info("{0} 洗衣单数据 被找到", oldTicketList.Count);

                    foreach (var item in oldTicketList)
                    {
                        var newItem = new Laundry.LibCore.Models.LaundryTicket();
                        newItem.GetClotheWay = item.PutWay == "自提" ? Laundry.LibCore.Models.ClotheWayType.Self : Laundry.LibCore.Models.ClotheWayType.StoreTo;
                        newItem.HasPay = item.MoneyState == "已付" ? true : false;
                        newItem.HasTakeOff = item.State == "已取" ? true : false;
                        newItem.PlanTakeAwayAt = item.QuYiDateTime;
                        newItem.CreateAt = item.ShouYiDateTime;
                        newItem.Mark = item.BeiZhu;
                        newItem.IDView = item.TicketID;
                        newItem.Vip = newDbContext.Vips.Where(i => i.VipID == item.UserID).FirstOrDefault();
                        //如果找不到这个用户，创建非VIP客户用户
                        if (newItem.Vip == null)
                        {
                            newItem.Vip = emptyCustomer;
                        }
                        newDbContext.LaundryTickets.Add(newItem);
                    }
                    newDbContext.SaveChanges();

                }
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }

        public Exception MigrationFeeRecords()
        {
            try
            {
                var emptyFeeRecord = new Laundry.LibCore.Models.FeeRecord();

                if (!newDbContext.FeeRecords.Any())
                {
                    emptyFeeRecord.IDView = "";
                    emptyFeeRecord.RealAccount = 0;
                    emptyFeeRecord.Account = 0;
                    emptyFeeRecord.GiftAccount = 0;
                    emptyFeeRecord.Mark = "未付款";
                    emptyFeeRecord.Vip = emptyCustomer;
                    emptyFeeRecord.FeeType = Laundry.LibCore.Models.FeeType.Empty;
                    newDbContext.FeeRecords.Add(emptyFeeRecord);
                    newDbContext.SaveChanges();

                    var oldFeeRecordList = oldDbContext.UCC_MoneyHistory.ToList();
                    logger.Info("{0} 消费记录数据 被找到", oldFeeRecordList.Count);

                    foreach (var item in oldFeeRecordList)
                    {
                        var newItem = new Laundry.LibCore.Models.FeeRecord();
                        newItem.IDView = item.MoneyID;
                        newItem.Mark = item.BeiZhu;
                        newItem.GiftAccount = (decimal)item.ZengSongMoney;
                        newItem.CreateAt = item.MoneyTime;
                        newItem.Vip = newDbContext.Vips.Where(i => i.Name == item.UserName).FirstOrDefault();
                        //如果找不到这个用户，创建非VIP客户用户
                        if (newItem.Vip == null)
                        {
                            newItem.Vip = emptyCustomer;
                        }
                        if (item.ShiShouMoney > 0)
                        {
                            if (item.ZengSongMoney > 0)
                            {
                                newItem.FeeType = Laundry.LibCore.Models.FeeType.CreateVip;
                            }
                            else
                            {
                                newItem.FeeType = Laundry.LibCore.Models.FeeType.Recharge;
                            }
                            newItem.Account = (decimal)item.Money;
                            newItem.RealAccount = (decimal)item.ShiShouMoney;
                        }
                        else
                        {
                            newItem.FeeType = Laundry.LibCore.Models.FeeType.LuandryTicket;
                            newItem.Account = -(decimal)item.Money;
                            newItem.RealAccount = -(decimal)item.ShiShouMoney;
                        }
                        if (newItem.Account < 0)
                            newItem.Account = -newItem.Account;
                        if (newItem.RealAccount < 0)
                            newItem.RealAccount = -newItem.RealAccount;

                        newDbContext.FeeRecords.Add(newItem);
                        newDbContext.SaveChanges();

                    }

                }
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }

        public Exception MigrationTicketClotheRecords()
        {
            try
            {
                var emptyBrand = new Laundry.LibCore.Models.Brand();
                var emptyColor = new Laundry.LibCore.Models.Color();
                if (!newDbContext.TicketClotheRecords.Any())
                {
                    emptyBrand.Text = "empty";
                    newDbContext.Brands.Add(emptyBrand);
                    newDbContext.SaveChanges();

                    emptyColor.Text = "empty";
                    newDbContext.Colors.Add(emptyColor);
                    newDbContext.SaveChanges();

                    var oldTicketClotheRecordList = oldDbContext.UCC_YiFu.ToList();
                    logger.Info("{0} Old TicketClotheRecords 被找到", oldTicketClotheRecordList.Count);

                    foreach (var item in oldTicketClotheRecordList)
                    {
                        var newItem = new Laundry.LibCore.Models.TicketClotheRecord();
                        newItem.Brand = item.PinPai;
                        newItem.Color = item.Color;
                        newItem.FlawRecords = new List<Laundry.LibCore.Models.FlawRecord>();
                        var flawArr = item.XiaCi.Split(',');
                        foreach (var f in flawArr)
                        {
                            if (f.Length < 2)
                                continue;
                            var find = newDbContext.Flaws.Where(t => f.Contains(t.Text)).FirstOrDefault();
                            if (find == null)
                            {
                                find = new Laundry.LibCore.Models.Flaw();
                                find.Text = f;
                                newDbContext.Flaws.Add(find);
                                newDbContext.SaveChanges();
                            }
                            var findR = new Laundry.LibCore.Models.FlawRecord();
                            findR.Text = f;
                            newItem.FlawRecords.Add(findR);
                        }
                        newItem.Price = decimal.Parse(item.Price);
                        newItem.Mark = item.BeiZhu;
                        newItem.LaundryTicket = newDbContext.LaundryTickets.Where(i => i.IDView == item.TicketID).FirstOrDefault();
                        newItem.Name = item.ClotheType;
                        newItem.IsDiscount = false;
                        newItem.Discount = 1;
                        newDbContext.TicketClotheRecords.Add(newItem);

                    }
                    newDbContext.SaveChanges();

                }
            }
            catch(Exception ex)
            {
                return ex;
            }
            return null;
        }

        public Exception CheckCanMigration()
        {
            return this.CanMigration ? null : new Exception("你可能已经执行过数据迁移，不能重复进行这个操作！");
        }

        public void DoMigration()
        {
            this.HasStarted = true;

            logger.Info("开始数据更新");

            Exception ex = null;
            foreach(var item in this.Steps)
            {
                ex = item.Value();
                if (ex != null)
                {
                    throw new Exception("数据迁移失败！", ex);
                }
                else
                {
                    var line = string.Format("工作：{0},完成", item.Key);
                    this.StepIndex++;
                    this.NewStep?.Invoke(this, line);
                }
            }

            logger.Info("结束数据迁移工作！");
        }
    }
}