using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace JoshTheGent.Localization
{
    public static class JoshTheGentLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(JoshTheGentConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(JoshTheGentLocalizationConfigurer).GetAssembly(),
                        "JoshTheGent.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
