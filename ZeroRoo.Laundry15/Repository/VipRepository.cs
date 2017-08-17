using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laundry.LibCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Laundry.LibCore.Repository
{
    public class VipRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }

        public VipRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public Vip Find(int id)
        {
            return this.LaundryDbContext.Vips.FirstOrDefault(item => item.ID == id);
        }

        public Vip FindByVipPhone(string phone)
        {
            return this.LaundryDbContext.Vips.FirstOrDefault(item => item.Phone == phone);
        }

        public Vip FindByVipID(string vipID)
        {
            return this.LaundryDbContext.Vips.FirstOrDefault(item => item.VipID == vipID);
        }

        public List<Vip> List()
        {
            return this.LaundryDbContext.Vips.ToList();
        }

        public List<Vip> Search(string filter)
        {
            var list = this.LaundryDbContext.Vips
                .Where(item => item.Phone.Contains(filter) || 
                    item.Name.Contains(filter) ||
                    item.VipID.Contains(filter))
                .ToList();
            foreach(var item in list)
            {
                var feeRecordList = this.LaundryDbContext.FeeRecords.Where(i => i.Vip == item).ToList();
                foreach(var fee in feeRecordList)
                {
                    item.FeeSum += fee.Account;
                }
                var ticketList = this.LaundryDbContext.LaundryTickets.Where(i => i.Vip == item).Include(i=>i.ClotheRecords).ToList();

                item.TicketCount = ticketList.Count;
                foreach(var ticket in ticketList)
                {
                    item.ClotheCount += ticket.ClotheRecords.Count;
                }
            }
            return list;
        }

        public void Save(NewVipPost post)
        {
            post.VipInfo.Balance = post.FeeRecord.Account + post.FeeRecord.GiftAccount;
            post.FeeRecord.FeeType = FeeType.CreateVip;
            this.LaundryDbContext.Vips.Add(post.VipInfo);
            this.LaundryDbContext.FeeRecords.Add(post.FeeRecord);
            this.LaundryDbContext.SaveChanges();
        }

        public void Save(Vip vip)
        {
            this.LaundryDbContext.Vips.Add(vip);
            this.LaundryDbContext.SaveChanges();
        }

        public void Recharge(FeeRecord entity)
        {
            entity.Vip = this.LaundryDbContext.Vips.FirstOrDefault(item => item.ID == entity.VipID);
            entity.BeforeUserBlance = entity.Vip.Balance;
            entity.AfterUserBlance = entity.Account + entity.GiftAccount;
            this.LaundryDbContext.FeeRecords.Add(entity);
            this.LaundryDbContext.Vips.Update(entity.Vip);
            this.LaundryDbContext.SaveChanges();
        }
    }
}
