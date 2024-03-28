using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DemoVineForce.Localization
{
    public static class DemoVineForceLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DemoVineForceConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DemoVineForceLocalizationConfigurer).GetAssembly(),
                        "DemoVineForce.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
