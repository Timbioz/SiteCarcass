using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Services;
using WebSite.Models;
using WebSite.Data;
using AutoMapper;

namespace Site.Areas.Admin.Controllers
{
    public partial class SectionsController : BaseController
    {
        private readonly ISectionsService sections;

        public SectionsController(ISectionsService sections)
        {
            this.sections = sections;
        }

        public virtual ActionResult Index()
        {
            var sect = sections.GetAll();
            var model = new SectionsIndexViewModel(sect);
            return View(model);
        }

        //public virtual ActionResult Details()
        //{
        //    return View();
        //}

        public virtual ActionResult Create()
        {
            var model = new SectionCreateViewModel();
            return View(model);
        }

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

        [HttpPost]
        public virtual ActionResult DeleteSelected(int[] select)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            foreach (var i in select)
            {
                sections.DeleteSection(i);
            }

            if (Request.IsAjaxRequest())
            {
                var sect = sections.GetAll();
                var model1 = new SectionsIndexViewModel(sect);
                return PartialView("SectionsPartials/_IndexGrid", model1);
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
