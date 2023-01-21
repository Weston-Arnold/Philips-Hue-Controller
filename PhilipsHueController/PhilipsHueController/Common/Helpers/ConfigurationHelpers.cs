using System.Configuration;

namespace PhilipsHueController.Common.Helpers
{
    public class ConfigurationHelpers
    {
        public static string GetAppSettingByKey(string key)
        {
            return ConfigurationManager.AppSettings[key] ?? null;
        }

        public static void AddOrUpdateAppSettingByKey(string key, string value)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = configuration.AppSettings.Settings;

            if (appSettings[key] == null)
            {
                appSettings.Add(key, value);
            }
            else
            {
                appSettings[key].Value = value;
            }

            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
        }

        public static void DeleteSettingByKey(string key)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = configuration.AppSettings.Settings;

            appSettings.Remove(key);

            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
        }
    }
}
