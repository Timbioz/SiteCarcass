using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;
using WebSite.Data;

namespace WebSite.Services
{
    public interface IPostsService
    {
        Posts GetTopic(int id);
        IEnumerable<Posts> GetAll();
        bool CreateTopic(Posts post);
        bool UpdateTopic(Posts post);
        bool DeleteTopic(int id);
        void DisposeCore();
    }
}
