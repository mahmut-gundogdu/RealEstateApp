using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RealEstateApp.Localization
{
    public static class RealEstateAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RealEstateAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RealEstateAppLocalizationConfigurer).GetAssembly(),
                        "RealEstateApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
