using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laundry.LibCore;
using Laundry.LibCore.Repository;
using Laundry.LibCore.Models;
using System.Collections.Generic;
using ZeroRoo.Configuration;
using System.Threading;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        VipRepository vipRepository = new VipRepository();
        LaundryRepository laundryRepository = new LaundryRepository();
        BrandRepository brandRepository = new BrandRepository();
        ColorRepository colorRepository = new ColorRepository();
        FlawRepository flawRepository = new FlawRepository();

        [TestMethod]
        public void VipSingleLine()
        {
            var vip = new Vip()
            {
                Name = "卢杰杰",
                VipID = "10000",
                Phone = "18516520" + new Random().Next(1000)
            };
            var vipPost = new NewVipPost()
            {
                 VipInfo = vip,
                  FeeRecord= new FeeRecord()
                  {
                       Account = 1000,
                       GiftAccount = 500,
                       Vip = vip
                  },
            };
            vipRepository.Save(vipPost);
            Thread.Sleep(1000);

            var lastVipBalance = vip.Balance;

            //开单
            var ticket = new LaundryTicket();
            ticket.GetClotheWay = ClotheWayType.Self;
            ticket.Mark = "测试";
            ticket.PlanTakeAwayAt = DateTime.Now.AddDays(3);
            ticket.VipID = vip.ID;
            ticket.ClotheRecords = new List<TicketClotheRecord>()
            {
                new TicketClotheRecord()
                {
                    Brand = "测试品牌",
                    Color = "测试颜色",
                    Name = "测试",
                    Price = 211,
                    FlawRecords = new List<FlawRecord>()
                    {
                        new FlawRecord()
                        {
                            Text = "测试"
                        }
                    },
                }
            };

            laundryRepository.Save(ticket);
            
            var feeSum = FeeCalculator.New().Calculate(ticket);
            laundryRepository.Pay(vip.ID, ticket.ID, feeSum / 2, feeSum / 2);

            Thread.Sleep(20000);
            Vip tmpVip = new Vip();
            tmpVip = vipRepository.Find(vip.ID);
            var nowBalance = tmpVip.Balance;
            Assert.AreEqual(lastVipBalance - (feeSum / 2), nowBalance);
        }

        [TestMethod]
        public void ConfigRead()
        {
            var storeInfo = ConfigManager.Default.Config<Store>();
            Assert.AreEqual("13761561263", storeInfo.Phone);
        }
        
        [TestMethod]
        public void SingleLine()
        {
            var laundryRepository = new LaundryRepository();
            var brandRepository = new BrandRepository();
            var colorRepository = new ColorRepository();
            var flawRepository = new FlawRepository();

            var ticket = new LaundryTicket();
            ticket.GetClotheWay = ClotheWayType.Self;
            ticket.Mark = "测试";
            ticket.PlanTakeAwayAt = DateTime.Now.AddDays(3);
            ticket.VipID = 1;
            ticket.ClotheRecords = new List<TicketClotheRecord>()
            {
                new TicketClotheRecord()
                {
                    Brand = brandRepository.List()[0].Text,
                    Color = colorRepository.List()[0].Text,
                    Name = "测试",
                    Price = 211,
                    FlawRecords = new List<FlawRecord>()
                    {
                        new FlawRecord()
                        {
                            Text = "测试"
                        }
                    },
                }
            };

            laundryRepository.Save(ticket);
        }
    }
}
