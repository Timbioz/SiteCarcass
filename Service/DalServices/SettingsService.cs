using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;
using WebSite.Data;

namespace WebSite.Services
{
    public class SettingsService : Disposable, ISettingsService
    {
        private readonly ISiteSettingsRepository settingsRepository;
        private readonly IUnitOfWork unitOfWork;

        public SettingsService(ISiteSettingsRepository settingsRepository, IUnitOfWork unitOfWork)
        {
            this.settingsRepository = settingsRepository;
            this.unitOfWork = unitOfWork;
        }

        public Settings GetSetting(int id)
        {
            return settingsRepository.GetById(id);
        }

        public IEnumerable<Settings> GetAllSettings()
        {
            return settingsRepository.GetAll();
        }

        public bool CreateSetting(Settings setting)
        {
            settingsRepository.Add(setting);
            unitOfWork.Commit();
            if (settingsRepository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateSetting(Settings setting) 
        {
            settingsRepository.Update(setting);
            unitOfWork.Commit();
            if (settingsRepository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteSetting(int id)
        {
            var setting = settingsRepository.GetById(id);
            settingsRepository.Delete(setting);
            unitOfWork.Commit();
            if (settingsRepository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public override void DisposeCore()
        {
            if(unitOfWork != null)
                unitOfWork.DisposeCore();
            base.DisposeCore();
        }
    }
}
