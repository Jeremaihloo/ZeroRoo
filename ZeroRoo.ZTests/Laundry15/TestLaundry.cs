using NUnit.Framework;
using System;
using ZeroRoo.Laundry15;
using Microsoft.Extensions.DependencyInjection;
using Laundry.DbMigration;
using ZeroRoo.Laundry15.Repository;
using ZeroRoo.Laundry15.Models;

namespace ZeroRoo.ZTests.Laundry15
{
    [TestFixture()]
    public class TestLaundry
    {
        private LaundryDbContext dbContext;
        private OldDbContext oldContext;
        private BrandRepository brandRep;
        private ClotheCategoryRepository clotheCategoryRep;
        private ColorRepository colorRep;
        private FeeRecordRepository feeRecordRep;
        private FlawRepository flawRep;
        private LaundryRepository laundryRep;
        private PriceRepository priceRep;
        private TicketClotheRecordRepository ticketClotheRecordRep;
        private UserRepository vipRep;

        public TestLaundry()
        {
            var services = new ServiceCollection();

            services.AddSingleton<LaundryDbContext>();
            services.AddSingleton<OldDbContext>();
            services.AddSingleton<BrandRepository>();
            services.AddSingleton<ClotheCategoryRepository>();
            services.AddSingleton<ColorRepository>();
            services.AddSingleton<FeeRecordRepository>();
            services.AddSingleton<FlawRepository>();
            services.AddSingleton<LaundryRepository>();
            services.AddSingleton<PriceRepository>();
            services.AddSingleton<TicketClotheRecordRepository>();
            services.AddSingleton<UserRepository>();

            var provider = services.BuildServiceProvider();
            dbContext = provider.GetRequiredService<LaundryDbContext>();
            oldContext = provider.GetRequiredService<OldDbContext>();
            brandRep = provider.GetRequiredService<BrandRepository>();
            clotheCategoryRep = provider.GetRequiredService<ClotheCategoryRepository>();
            colorRep = provider.GetRequiredService<ColorRepository>();
            feeRecordRep = provider.GetRequiredService<FeeRecordRepository>();
            flawRep = provider.GetRequiredService<FlawRepository>();
            laundryRep = provider.GetRequiredService<LaundryRepository>();
            priceRep = provider.GetRequiredService<PriceRepository>();
            ticketClotheRecordRep = provider.GetRequiredService<TicketClotheRecordRepository>();
            vipRep = provider.GetRequiredService<UserRepository>();
        }

        [Test()]
        public void TestBrand()
        {
            var brand = new Brand()
            {
                Text = "测试品牌"
            };
            dbContext.Brands.Add(brand);
            dbContext.SaveChanges();
            Assert.IsTrue(brand.ID > 0);
        }
    }
}
