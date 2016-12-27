using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laundry.LibCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Laundry.LibCore.Repository
{
    public class LaundryRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }

        public LaundryRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public LaundryTicket Find(int id)
        {
            return this.LaundryDbContext.LaundryTickets.FirstOrDefault(item => item.ID == id);
        }

        public LaundryTicket Find(string idView)
        {
            return this.LaundryDbContext.LaundryTickets.FirstOrDefault(item => item.IDView == idView);
        }

        public void Save(LaundryTicket ticket)
        {
            this.LaundryDbContext.LaundryTickets.Add(ticket);
            this.LaundryDbContext.SaveChanges();
        }

        public void Update(LaundryTicket ticket)
        {
            this.LaundryDbContext.LaundryTickets.Update(ticket);
            this.LaundryDbContext.SaveChanges();
        }

        public List<LaundryTicket> Search(string filter)
        {
            return this.LaundryDbContext.LaundryTickets
                .Where(item => item.IDView.Contains(filter) ||
                        item.Vip.Phone.Contains(filter) ||
                        item.Vip.Name.Contains(filter))
                .Include(item => item.ClotheRecords)
                    .ThenInclude(clothe => clothe.FlawRecords)
                .Include(item => item.Vip)
                .ToList();
        }

        public void Pay(int vipID, int ticketID, decimal fromCash, decimal fromVip)
        {

            //费用
            var fee = new FeeRecord();
            fee.FromCash = fromCash;
            fee.FromVip = fromVip;
            fee.Account = fromCash + fromVip;
            fee.RealAccount = fee.Account;
            fee.VipID = vipID;
            fee.TicketID = ticketID;
            this.LaundryDbContext.FeeRecords.Add(fee);

            //衣单
            var ticket = this.LaundryDbContext.LaundryTickets.FirstOrDefault(item=>item.ID == ticketID);
            ticket.HasPay = true;

            this.LaundryDbContext.LaundryTickets.Update(ticket);

            var vip = this.LaundryDbContext.Vips.FirstOrDefault(item => item.ID == vipID);
            vip.Balance -= fee.FromVip;

            this.LaundryDbContext.Vips.Update(vip);
            this.LaundryDbContext.SaveChanges();
        }

        public void TakeOff(List<LaundryTicket> ticketList)
        {
            foreach(var ticket in ticketList)
            {
                foreach (var item in ticket.ClotheRecords)
                {
                    item.State = TicketClotheState.TakeOff;
                    this.LaundryDbContext.TicketClotheRecords.Update(item);
                }
                ticket.HasTakeOff = true;
                this.LaundryDbContext.LaundryTickets.Update(ticket);
            }
            this.LaundryDbContext.SaveChanges();

        }

        public void TakeOff(LaundryTicket ticket)
        {
            foreach(var item in ticket.ClotheRecords)
            {
                item.State = TicketClotheState.TakeOff;
                this.LaundryDbContext.TicketClotheRecords.Update(item);
            }
            ticket.HasTakeOff = true;
            this.LaundryDbContext.LaundryTickets.Update(ticket);
            this.LaundryDbContext.SaveChanges();
        }

        public void TakeOff(List<TicketClotheRecord> ticketClotheList)
        {
            foreach(var item in ticketClotheList)
            {
                item.State = TicketClotheState.TakeOff;
                this.LaundryDbContext.TicketClotheRecords.Update(item);
            }
            this.LaundryDbContext.SaveChanges();
        }

        public void TakeOff(TicketClotheRecord ticketClothe)
        {
            ticketClothe.State = TicketClotheState.TakeOff;
            this.LaundryDbContext.TicketClotheRecords.Update(ticketClothe);
            this.LaundryDbContext.SaveChanges();
            var allCount = ticketClothe.LaundryTicket.ClotheRecords.Count;
            var hasTakeOff = ticketClothe.LaundryTicket.ClotheRecords.Where(item => item.State == TicketClotheState.TakeOff).Count();
            var finish =  allCount == hasTakeOff;
            if(finish)
            {
                ticketClothe.LaundryTicket.HasTakeOff = true;
                this.LaundryDbContext.LaundryTickets.Update(ticketClothe.LaundryTicket);
                this.LaundryDbContext.SaveChanges();
            }
        }
    }
}
