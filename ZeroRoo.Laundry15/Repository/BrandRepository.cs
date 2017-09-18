using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Laundry15.Models;

namespace ZeroRoo.Laundry15.Repository
{
    public class BrandRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }

        public BrandRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public List<Brand> List()
        {
            return this.LaundryDbContext.Brands.ToList();
        }

        public void Save(Brand brand)
        {
            this.LaundryDbContext.Brands.Add(brand);
            this.LaundryDbContext.SaveChanges();
        }

        public void Update(Brand brand)
        {
            this.LaundryDbContext.Brands.Update(brand);
            this.LaundryDbContext.SaveChanges();
        }
    }
}
