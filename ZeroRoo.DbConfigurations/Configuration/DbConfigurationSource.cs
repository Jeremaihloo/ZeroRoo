using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.DbConfigurations
{
    public class DbConfigurationSource : IConfigurationSource
    {
        private Action<DbContextOptionsBuilder> _setup;
        private IDictionary<string, string> _initialSettings;

        public DbConfigurationSource(Action<DbContextOptionsBuilder> setup, IDictionary<string, string> initialSettings = null)
        {
            _setup = setup;
            _initialSettings = initialSettings;
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new DbConfigurationProvider(_setup, _initialSettings);
        }
    }
}