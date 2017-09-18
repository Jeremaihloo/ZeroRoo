using NUnit.Framework;
using System;
using ZeroRoo.Laundry15;
using Microsoft.Extensions.DependencyInjection;
using Laundry.DbMigration;
using ZeroRoo.Laundry15.Repository;

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
        private VipRepository vipRep;

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
            services.AddSingleton<VipRepository>();

            var provider = services.BuildServiceProvider();

        }

        [Test()]
        public void TestCase()
        {
        }
    }
}
