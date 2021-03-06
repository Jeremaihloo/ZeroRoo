﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laundry.LibCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Laundry.LibCore.Repository
{
    public class PriceRepository
    {
        public LaundryDbContext LaundryDbContext { get; set; }

        public PriceRepository()
        {
            this.LaundryDbContext = new LaundryDbContext();
        }

        public void Save(Price price)
        {
            this.LaundryDbContext.Prices.Add(price);
            this.LaundryDbContext.SaveChanges();
        }

        public List<Price> List()
        {
            return this.LaundryDbContext.Prices
                .ToList();
        }

        public void Update(Price price)
        {
            this.LaundryDbContext.Prices.Update(price);
            this.LaundryDbContext.SaveChanges();
        }
    }
}
