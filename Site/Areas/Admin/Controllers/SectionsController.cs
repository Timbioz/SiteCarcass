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
        private readonly ISectionsService sections;

        public SectionsController(ISectionsService sections)
        {
            this.sections = sections;
        }
        //!+Index
        public virtual ActionResult Index()
        {
            return View();
        }

        //!+Table Handler 
        [HttpGet]
        public virtual ActionResult AjaxDataTableHandler(JQueryDataTableParametersModel param)
        {
            var allSect = sections.GetAll().Count();

            IEnumerable<Sections> filtered = !string.IsNullOrEmpty(param.sSearch) ? sections.GetAll().Where(c => (c.Name ?? "").ToLower().Contains(param.sSearch.ToLower()) || (c.Description ?? "").ToLower().Contains(param.sSearch.ToLower())) : sections.GetAll();

            

            var isNameSortable = Convert.ToBoolean(Request["bSortable_1"]);
            var isDescriptionSortable = Convert.ToBoolean(Request["bSortable_2"]);
            var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);

            Func<Sections, string> ordering = (c => sortColumnIndex == 1 && isNameSortable ? c.Name :
                                                    sortColumnIndex == 2 && isDescriptionSortable ? c.Description : "");

            var sortDirection = Request["sSortDir_0"]; // asc or desc
            if (sortDirection == "asc")
                filtered = filtered.OrderBy(ordering);
            else
                filtered = filtered.OrderByDescending(ordering);

            var displayed = filtered
                .Skip(param.iDisplayStart)
                .Take(param.iDisplayLength);

            var model = from c in displayed
                        select new[] {Convert.ToString(c.SectionId), c.Name, c.Description};
            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = allSect,
                iTotalDisplayRecords = filtered.Count(),
                aaData = model
            },
            JsonRequestBehavior.AllowGet);
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
