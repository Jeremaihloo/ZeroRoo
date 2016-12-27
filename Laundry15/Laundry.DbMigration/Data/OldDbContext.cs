using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Laundry.DbMigration;

namespace Laundry.DbMigration
{
    public class OldDbContext : DbContext
    {
        public virtual DbSet<MoneyHistory> UCC_MoneyHistory { get; set; }

        public virtual DbSet<PinPai> UCC_PinPai { get; set; }

        public virtual DbSet<ShouYi> UCC_ShouYi { get; set; }

        public virtual DbSet<User> UCC_User { get; set; }

        public virtual DbSet<XiaCi> UCC_XiaCi { get; set; }

        public virtual DbSet<YanSe> UCC_YanSe { get; set; }

        public virtual DbSet<YiFu> UCC_YiFu { get; set; }

        public virtual DbSet<YiFuPriceType> UCC_YiFuPriceType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./old.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MoneyHistory>()
                .HasKey(item=>item.MoneyID);
            
            modelBuilder.Entity<ShouYi>()
                .HasKey(item=>item.TicketID);

            modelBuilder.Entity<YiFu>()
                .HasKey(item=>item.ClotheID);
            
            modelBuilder.Entity<YiFuPriceType>()
                .HasKey(item=>item.YiFuPriceID);
        }
    }
}