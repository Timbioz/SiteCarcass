using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;
using WebSite.Data;

namespace WebSite.Services
{
    public interface ISectionsService
    {
        Sections GetSection(int id);
        IEnumerable<Sections> GetAll();
        bool CreateSection(Sections section);
        bool CreateMapping(object viewModel);
        bool UpdateSection(Sections section);
        bool DeleteSection(int id);
        void DisposeCore();
    }
}
