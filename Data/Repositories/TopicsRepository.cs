using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;

namespace WebSite.Data
{
    public class TopicsRepository : RepositoryBase<Topics>, ITopicsRepository
    {
        public TopicsRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
