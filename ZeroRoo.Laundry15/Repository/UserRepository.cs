using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Laundry15.Models;
using Microsoft.EntityFrameworkCore;

namespace ZeroRoo.Laundry15.Repository
{
    public class VipRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }

        public VipRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public UserProfile Find(int id)
        {
            return this.LaundryDbContext.UserProfiles.FirstOrDefault(item => item.ID == id);
        }

        public UserProfile FindByVipPhone(string phone)
        {
            return this.LaundryDbContext.UserProfiles.FirstOrDefault(item => item.Phone == phone);
        }

        public UserProfile FindByVipID(string vipID)
        {
            return this.LaundryDbContext.UserProfiles.FirstOrDefault(item => item.VipID == vipID);
        }

        public List<UserProfile> List()
        {
            return this.LaundryDbContext.UserProfiles.ToList();
        }

        public List<UserProfile> Search(string filter)
        {
            var list = this.LaundryDbContext.UserProfiles
                .Where(item => item.Phone.Contains(filter) ||
                    item.Name.Contains(filter) ||
                    item.VipID.Contains(filter))
                .ToList();
            foreach (var item in list)
            {
                var feeRecordList = this.LaundryDbContext.FeeRecords.Where(i => i.Customer == item).ToList();
                foreach (var fee in feeRecordList)
                {
                    item.FeeSum += fee.Account;
                }
                var ticketList = this.LaundryDbContext.LaundryTickets.Where(i => i.Customer == item).Include(i => i.ClotheRecords).ToList();

                item.TicketCount = ticketList.Count;
                foreach (var ticket in ticketList)
                {
                    item.ClotheCount += ticket.ClotheRecords.Count;
                }
            }
            return list;
        }

        // TODO:
        //public void Save(int uid, )
        //{
        //    post.VipInfo.Balance = post.FeeRecord.Account + post.FeeRecord.GiftAccount;
        //    post.FeeRecord.FeeType = FeeType.CreateVip;
        //    this.LaundryDbContext.Users.Add(post.VipInfo);
        //    this.LaundryDbContext.FeeRecords.Add(post.FeeRecord);
        //    this.LaundryDbContext.SaveChanges();
        //}

        public void Save(UserProfile vip)
        {
            this.LaundryDbContext.UserProfiles.Add(vip);
            this.LaundryDbContext.SaveChanges();
        }

        public void Recharge(FeeRecord entity)
        {
            entity.Customer = this.LaundryDbContext.UserProfiles.FirstOrDefault(item => item.ID == entity.CustomerID);
            entity.BeforeUserBlance = entity.Customer.Balance;
            entity.AfterUserBlance = entity.Account + entity.GiftAccount;
            this.LaundryDbContext.FeeRecords.Add(entity);
            this.LaundryDbContext.UserProfiles.Update(entity.Customer);
            this.LaundryDbContext.SaveChanges();
        }
    }
}
