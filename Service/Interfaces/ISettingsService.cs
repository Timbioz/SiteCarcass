using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;

namespace WebSite.Services
{
    public interface ISettingsService
    {
        Settings GetSetting(int id);
        IEnumerable<Settings> GetAllSettings();
        bool CreateSetting(Settings setting);
        bool UpdateSetting(Settings setting);
        bool DeleteSetting(int id);
        void DisposeCore();
    }
}
