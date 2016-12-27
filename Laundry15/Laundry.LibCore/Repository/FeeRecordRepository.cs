using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laundry.LibCore.Models;

namespace Laundry.LibCore.Repository
{
    public class FeeRecordRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }

        public FeeRecordRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public List<FeeRecord> List()
        {
            return this.LaundryDbContext.FeeRecords.ToList();
        }
    }
}
