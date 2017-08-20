using Microsoft.Extensions.Configuration;

namespace ZeroRoo.Parser.Yaml
{
    /// <summary>
    /// A Yaml file based <see cref="FileConfigurationSource"/>
    /// </summary>
    public class YamlConfigurationSource : FileConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            FileProvider = FileProvider ?? builder.GetFileProvider();
            return new YamlConfigurationProvider(this);
        }
    }
}