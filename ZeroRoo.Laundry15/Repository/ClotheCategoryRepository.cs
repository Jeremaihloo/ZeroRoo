using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Laundry15.Models;
using Microsoft.EntityFrameworkCore;

namespace ZeroRoo.Laundry15.Repository
{
    public class ClotheCategoryRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }

        public ClotheCategoryRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public List<ClotheCategory> List()
        {
            return this.LaundryDbContext.ClotheCategories
                .Include(item=>item.ClotheInfos)
                .ToList();
        }

        public void Save(ClotheCategory cc)
        {
            this.LaundryDbContext.ClotheCategories.Add(cc);
            this.LaundryDbContext.SaveChanges();
        }

        public void Update(ClotheCategory cc)
        {
            this.LaundryDbContext.ClotheCategories.Update(cc);
            this.LaundryDbContext.SaveChanges();
        }
    }
}
