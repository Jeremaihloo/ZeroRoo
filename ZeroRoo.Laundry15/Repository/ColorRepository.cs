using ZeroRoo.Laundry15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Laundry15.Repository
{
    public class ColorRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }

        public ColorRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public List<Color> List()
        {
            return this.LaundryDbContext.Colors.ToList();
        }

        public void Save(Color color)
        {
            this.LaundryDbContext.Colors.Add(color);
            this.LaundryDbContext.SaveChanges();
        }

        public void Update(Color color)
        {
            this.LaundryDbContext.Update(color);
            this.LaundryDbContext.SaveChanges();
        }
    }
}
