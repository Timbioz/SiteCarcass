using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcContrib.UI.Grid;
using PagedList;
using WebSite.Services;
using WebSite.Models;
using MvcContrib.Sorting;


namespace Site.Areas.Admin.Controllers
{
    public partial class SectionsController : BaseController
    {
        private readonly ISectionsService sections;

        public SectionsController(ISectionsService sections)
        {
            this.sections = sections;
        }
        //!+Index
        public virtual ActionResult Index(GridSortOptions sort, int? page)
        {
            var pageNumber = page ?? 1;
            var sect = sections.GetAll();
            if (sort.Column != null)
                sect = sect.OrderBy(sort.Column, sort.Direction);
            var model = new SectionsIndexViewModel(sect, pageNumber, 20);
            ViewData["sort"] = sort;
            return View(model);
        }

        //public virtual ActionResult Details()
        //{
        //    return View();
        //}
        //!+Create /get
        public virtual ActionResult Create()
        {
            var model = new SectionCreateViewModel();
            return View(model);
        }
        //!+Create /post
        [HttpPost]
        public virtual ActionResult Create(SectionCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            sections.CreateMapping(model);
            return RedirectToAction("Index");
        }
        //!+DeleteSelected /post/ajax
        [HttpPost]
        public virtual ActionResult DeleteSelected(int[] select, GridSortOptions sort, int? page)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");
            var count = select.Count();
            if (select != null)
                sections.DeleteGroup(select);
            //!ajax
            if (Request.IsAjaxRequest())
            {
                var pageNumber = page ?? 1;
                ViewData["Delcount"] = count.ToString();
                var sect = sections.GetAll();
                if (sort.Column != null)
                    sect = sect.OrderBy(sort.Column, sort.Direction);
                var model = new SectionsIndexViewModel(sect, pageNumber, 20);
                return PartialView("SectionsPartials/_IndexGrid", model);
            }

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            sections.DisposeCore();
            base.Dispose(disposing);
        }
    }
}
