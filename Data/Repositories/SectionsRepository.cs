using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;

namespace WebSite.Data
{
    public class SectionsRepository : RepositoryBase<Sections>, ISectionsRepository
    {
        public SectionsRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
