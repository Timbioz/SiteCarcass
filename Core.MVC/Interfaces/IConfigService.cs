using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSite.Core
{
    /// <summary>
    /// Gets or Sets configuration settings for site.
    /// </summary>
    public interface IConfigService
    {
        IDictionary<string, string> GetAllSettings();
        T GetSetting<T>(string key);
        void SetSetting<T>(string key, T value);
    }
}
