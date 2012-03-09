using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcContrib.UI.Grid;
using WebSite.Services;
using WebSite.Models;
using MvcContrib.Sorting;


namespace Site.Areas.Admin.Controllers
{
    public partial class SectionsController : BaseController
    {
        #region Initialization
        private readonly ISectionsService sections;

        public SectionsController(ISectionsService sections)
        {
            this.sections = sections;
        } 
        #endregion


        //!+Index
        public virtual ActionResult Index()
        {
            return View();
        }

        //!+Table Handler 
        [HttpGet]
        public virtual ActionResult AjaxDataTableHandler(JQueryDataTableParametersModel param)
        {
            
            var sect = sections.GetAll();
            var table = new SectionsTable();

            return Json(table.RequestTable(sect, Request, param), JsonRequestBehavior.AllowGet);
        }
        



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
        

        protected override void Dispose(bool disposing)
        {
            sections.DisposeCore();
            base.Dispose(disposing);
        }
    }
}
