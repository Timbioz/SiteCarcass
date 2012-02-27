using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using WebSite.Core;

namespace WebSite.Services
{
    public class ConfigService : IConfigService
    {
        public IDictionary<string, string> GetAllSettings()
        {
            var settings = new Dictionary<string, string>();
            var appSettings = ConfigurationManager.AppSettings;
            foreach (var setting in appSettings.AllKeys)
            {
                settings.Add(setting, appSettings[setting]);
            }

            return settings;
        }

        public T GetSetting<T>(string key)
        {
            var result = default(T);
            var setting = ConfigurationManager.AppSettings[key];
            if (!string.IsNullOrEmpty(setting))
                result = Utilites.To<T>(setting);
            return result;
        }

        public void SetSetting<T>(string key, T value)
        {
            throw new InvalidOperationException("Cannot save settings to the application configuration file");
        }
    }
}
