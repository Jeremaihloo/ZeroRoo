using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Laundry.LibCore;
using Laundry.LibCore.Models;

namespace Laundry.LibCore.Migrations
{
    [DbContext(typeof(LaundryDbContext))]
    [Migration("20161226080529_Create")]
    partial class Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("Laundry.LibCore.Models.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<string>("Text");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<int>("ViewIndex");

                    b.HasKey("ID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.ClotheCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<string>("Text");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.HasKey("ID");

                    b.ToTable("ClotheCategories");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.Color", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<string>("Text");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.HasKey("ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.FeeRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Account");

                    b.Property<decimal>("AfterUserBlance");

                    b.Property<decimal>("BeforeUserBlance");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<int>("FeeType");

                    b.Property<decimal>("FromCash");

                    b.Property<decimal>("FromVip");

                    b.Property<decimal>("GiftAccount");

                    b.Property<string>("IDView")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "strftime('%Y%m%d%H%M%S','now','localtime')");

                    b.Property<string>("Mark");

                    b.Property<decimal>("RealAccount");

                    b.Property<int>("TicketID");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<int>("VipID");

                    b.HasKey("ID");

                    b.HasIndex("IDView")
                        .IsUnique();

                    b.HasIndex("VipID");

                    b.ToTable("FeeRecords");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.Flaw", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<string>("Text");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.HasKey("ID");

                    b.ToTable("Flaws");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.FlawRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<string>("Text");

                    b.Property<int>("TicketClotheRecordID");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.HasKey("ID");

                    b.HasIndex("TicketClotheRecordID");

                    b.ToTable("FlawRecords");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.LaundryTicket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<int>("GetClotheWay");

                    b.Property<bool>("HasPay");

                    b.Property<bool>("HasTakeOff");

                    b.Property<string>("IDView")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "strftime('%Y%m%d%H%M%S','now','localtime')");

                    b.Property<string>("Mark");

                    b.Property<DateTime>("PlanTakeAwayAt");

                    b.Property<DateTime>("RealTakeAwayAt");

                    b.Property<int>("TakeOffClotheWay");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<int>("VipID");

                    b.HasKey("ID");

                    b.HasIndex("VipID");

                    b.ToTable("LaundryTickets");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.Price", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanDiscount");

                    b.Property<int>("CategoryID");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<bool>("IsDiscount");

                    b.Property<string>("Name");

                    b.Property<decimal>("NowDiscount");

                    b.Property<string>("PriceString");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.TicketClotheRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Color");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<decimal>("Discount");

                    b.Property<bool>("IsDiscount");

                    b.Property<int>("LaundryTicketID");

                    b.Property<string>("Loacation");

                    b.Property<string>("Mark");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("RealTakeOffAt");

                    b.Property<int>("State");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.HasKey("ID");

                    b.HasIndex("LaundryTicketID");

                    b.ToTable("TicketClotheRecords");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.Vip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Sex");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasAnnotation("Sqlite:DefaultValueSql", "datetime('now', 'localtime')");

                    b.Property<string>("VipID");

                    b.HasKey("ID");

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.ToTable("Vips");
                });

            modelBuilder.Entity("Laundry.LibCore.Models.FeeRecord", b =>
                {
                    b.HasOne("Laundry.LibCore.Models.Vip", "Vip")
                        .WithMany()
                        .HasForeignKey("VipID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Laundry.LibCore.Models.FlawRecord", b =>
                {
                    b.HasOne("Laundry.LibCore.Models.TicketClotheRecord", "TicketClotheRecord")
                        .WithMany("FlawRecords")
                        .HasForeignKey("TicketClotheRecordID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Laundry.LibCore.Models.LaundryTicket", b =>
                {
                    b.HasOne("Laundry.LibCore.Models.Vip", "Vip")
                        .WithMany()
                        .HasForeignKey("VipID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Laundry.LibCore.Models.Price", b =>
                {
                    b.HasOne("Laundry.LibCore.Models.ClotheCategory", "Category")
                        .WithMany("ClotheInfos")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Laundry.LibCore.Models.TicketClotheRecord", b =>
                {
                    b.HasOne("Laundry.LibCore.Models.LaundryTicket", "LaundryTicket")
                        .WithMany("ClotheRecords")
                        .HasForeignKey("LaundryTicketID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
