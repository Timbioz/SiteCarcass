using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;


namespace WebSite.Data
{
    public class SiteSettingsRepository : RepositoryBase<Settings>, ISiteSettingsRepository
    {
        public SiteSettingsRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }

    }
}
