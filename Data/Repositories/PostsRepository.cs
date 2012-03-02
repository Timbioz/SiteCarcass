using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;

namespace WebSite.Data
{
    public class PostsRepository : RepositoryBase<Posts>, IPostsRepository
    {
        public PostsRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
