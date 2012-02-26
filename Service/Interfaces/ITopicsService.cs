using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;
using WebSite.Data;

namespace WebSite.Services
{
    public interface ITopicsService
    {
        Topics GetTopic(int id);
        IEnumerable<Topics> GetAll();
        bool CreateTopic(Topics topic);
        bool UpdateTopic(Topics topic);
        bool DeleteTopic(int id);
        void DisposeCore();
    }
}
