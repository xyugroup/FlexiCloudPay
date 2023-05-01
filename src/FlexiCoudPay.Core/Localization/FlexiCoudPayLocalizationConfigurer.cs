using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FlexiCoudPay.Localization
{
    public static class FlexiCoudPayLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FlexiCoudPayConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FlexiCoudPayLocalizationConfigurer).GetAssembly(),
                        "FlexiCoudPay.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
