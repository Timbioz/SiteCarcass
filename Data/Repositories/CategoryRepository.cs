using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;


namespace WebSite.Data
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
            
        }
    }
}
