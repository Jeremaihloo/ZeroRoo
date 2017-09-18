using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Laundry15.Models;

namespace ZeroRoo.Laundry15.Repository
{
    public class TicketClotheRecordRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }
        public TicketClotheRecordRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }
        public List<TicketClotheRecord> List()
        {
            return this.LaundryDbContext.TicketClotheRecords.ToList();
        }
    }
}
