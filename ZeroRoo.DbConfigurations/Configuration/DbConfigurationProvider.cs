using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ZeroRoo.DbConfigurations
{
    public class DbConfigurationProvider : ConfigurationProvider
    {
        private IDictionary<string, string> _initialSettings;
        private Action<DbContextOptionsBuilder> _setup;
     
        public DbConfigurationProvider(Action<DbContextOptionsBuilder> setup, IDictionary<string, string> initialSettings)
        {
            _setup               = setup;
            _initialSettings     = initialSettings?? new Dictionary<string, string>() ;
       }
    
       public override void Load()
       {
           DbContextOptionsBuilder<ApplicationSettingsContext> builder = new DbContextOptionsBuilder<ApplicationSettingsContext>();
           _setup(builder);
           using (ApplicationSettingsContext dbContext = new ApplicationSettingsContext(builder.Options))
           {
               dbContext.Database.EnsureCreated();
               this.Data = dbContext.Settings.Any() ? dbContext.Settings.ToDictionary(it => it.Key, it => it.Value, StringComparer.OrdinalIgnoreCase) : this.Initialize(dbContext);
           }
       }
    
       private IDictionary<string, string> Initialize(ApplicationSettingsContext dbContext)
       {
           foreach (var item in _initialSettings)
           {
               dbContext.Settings.Add(new ApplicationSetting(item.Key, item.Value));
           }
           return _initialSettings.ToDictionary(it => it.Key, it => it.Value, StringComparer.OrdinalIgnoreCase);
       }
   }

    }