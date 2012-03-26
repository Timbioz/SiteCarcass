using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Services;
using WebSite.Models;

namespace Site.Areas.Admin.Controllers
{
    public partial class CategoriesController : BaseController
    {
        private ICategoryService category;
        private ISectionsService sections;

        public CategoriesController(ICategoryService category, ISectionsService sections)
        {
            this.category = category;
            this.sections = sections;
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Create()
        {
            var sect = sections.GetAll();
            var model = new CreateCategoryViewModel(sect, null);
            return View(model);
        }
        [HttpPost]
        public virtual ActionResult Create(CreateCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            sections.CreateSection(model);
            return RedirectToAction("Index");
        }
    }
}
