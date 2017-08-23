using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.DbConfigurations
{
    public static class DbConfigurationExtensions
    {
        public static IConfigurationBuilder AddDatabase(this IConfigurationBuilder builder, string connectionStringName, IDictionary<string, string> initialSettings = null)
        {
            string connectionString = builder.Build().GetConnectionString(connectionStringName);
            DbConfigurationSource source = new DbConfigurationSource(optionsBuilder => optionsBuilder.UseSqlite(connectionString), initialSettings);
            builder.Add(source);
            return builder;
        }
    }
}
