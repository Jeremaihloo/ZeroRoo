using Microsoft.EntityFrameworkCore;
using Laundry.LibCore.Models;

namespace Laundry.LibCore
{
    public class LaundryDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<FeeRecord> FeeRecords { get; set; }

        public DbSet<Flaw> Flaws { get; set; }

        public DbSet<FlawRecord> FlawRecords { get; set; }

        public DbSet<LaundryTicket> LaundryTickets { get; set; }

        public DbSet<TicketClotheRecord> TicketClotheRecords { get; set; }

        public DbSet<Vip> Vips { get; set; }

        public DbSet<ClotheCategory> ClotheCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlite("Filename=./laundry.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<Brand>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");

            modelBuilder.Entity<Price>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<Price>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");

            modelBuilder.Entity<Color>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<Color>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");

            modelBuilder.Entity<FeeRecord>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<FeeRecord>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<FeeRecord>()
                .HasIndex(item => item.IDView)
                .IsUnique();
            // 第一次数据迁移要注释掉
            modelBuilder.Entity<FeeRecord>()
                .Property(item => item.IDView)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("strftime('%Y%m%d%H%M%S','now','localtime')");

            modelBuilder.Entity<Flaw>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<Flaw>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");

            modelBuilder.Entity<FlawRecord>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<FlawRecord>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");

            modelBuilder.Entity<LaundryTicket>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<LaundryTicket>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");

            // 第一次数据迁移要注释掉
            modelBuilder.Entity<LaundryTicket>()
                .Property(item => item.IDView)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("strftime('%Y%m%d%H%M%S','now','localtime')");

            modelBuilder.Entity<TicketClotheRecord>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<TicketClotheRecord>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");

            modelBuilder.Entity<Vip>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<Vip>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<Vip>()
                .HasIndex(item => item.Phone)
                .IsUnique();
            modelBuilder.Entity<Vip>()
                .Ignore(item => item.FeeSum);
            modelBuilder.Entity<Vip>()
                .Ignore(item => item.TicketCount);
            modelBuilder.Entity<Vip>()
                .Ignore(item => item.ClotheCount);
            
            modelBuilder.Entity<ClotheCategory>()
                .Property(item => item.CreateAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("datetime('now', 'localtime')");
            modelBuilder.Entity<ClotheCategory>()
                .Property(item => item.UpdateAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("datetime('now', 'localtime')");
        }
    }
}