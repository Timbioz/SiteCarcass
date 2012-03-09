using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Models;

namespace WebSite.Services
{
    public interface ICategoryService
    {
        int TotalCount();
        Category GetCategory(int id);
        IEnumerable<Category> GetAll();
        bool CreateCategory(Category entity);
        bool CreateMapping(object viewModel);
        bool UpdateCategory(Category entity);
        bool DeleteCategory(int id);
        bool DeleteGroup(IEnumerable<int> id);
        void DisposeCore();
    }
}
