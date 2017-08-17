using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laundry.LibCore.Models;

namespace Laundry.LibCore.Repository
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
