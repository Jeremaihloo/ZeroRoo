using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.DbConfigurations
{
    public class ApplicationSettingsContext : DbContext
    {
        public ApplicationSettingsContext(DbContextOptions options) : base(options)
        { }

        public DbSet<ApplicationSetting> Settings { get; set; }
    }
}