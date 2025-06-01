using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace abpcqrstest.Localization;

public static class abpcqrstestLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(abpcqrstestConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(abpcqrstestLocalizationConfigurer).GetAssembly(),
                    "abpcqrstest.Localization.SourceFiles"
                )
            )
        );
    }
}
