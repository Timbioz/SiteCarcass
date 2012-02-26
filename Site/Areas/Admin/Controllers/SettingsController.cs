using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Services;
using WebSite.Data;
using WebSite.Models;
using MvcContrib.Sorting;
using MvcContrib.UI.Grid;
using MvcContrib.Pagination;

namespace Site.Areas.Admin.Controllers
{
    public partial class SettingsController : Controller
    {
        private readonly ISettingsService settings;

        public SettingsController(ISettingsService settings)
        {
            this.settings = settings;
        }

        public virtual ActionResult Index()
        {
            var model = settings.GetAllSettings();
            return View(model);
        }

        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Create(Settings siteSettings)
        {
            settings.CreateSetting(siteSettings);
            return RedirectToAction("Index");
        }

        public virtual ActionResult Grid(GridSortOptions sort, int? page)
        {
            var model = settings.GetAllSettings().AsPagination(page ?? 1, 10) as IEnumerable<Settings>;

            if (sort.Column != null)
            {
                model = model.OrderBy(sort.Column, sort.Direction);
            }
            ViewData["sort"] = sort;
            return View(model);
        }

        

        protected override void Dispose(bool disposing)
        {
            settings.DisposeCore();
            base.Dispose(disposing);
        }

    }
}
