using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Laundry15.Models;

namespace ZeroRoo.Laundry15.Repository
{
    public class FlawRepository
    {
        public FlawRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public LaundryDbContext LaundryDbContext { get; set; }

        public List<Flaw> List()
        {
            return this.LaundryDbContext.Flaws.ToList();
        }

        public void Save(Flaw flaw)
        {
            this.LaundryDbContext.Flaws.Add(flaw);
            this.LaundryDbContext.SaveChanges();
        }

        public void Update(Flaw flaw)
        {
            this.LaundryDbContext.Flaws.Update(flaw);
            this.LaundryDbContext.SaveChanges();
        }
    }
}
