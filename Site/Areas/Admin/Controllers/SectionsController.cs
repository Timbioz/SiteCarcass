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
            var model = sections.GetAll();
            var dto_model = new SectionViewModel();
            Mapper.CreateMap<Sections, SectionViewModel>();
            Mapper.Map(model, dto_model);
            return View(dto_model as IEnumerable<SectionViewModel>);
        }

        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Create(SectionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            sections.CreateMapping(model);
            return View("Index");
        }

        protected override void Dispose(bool disposing)
        {
            sections.DisposeCore();
            base.Dispose(disposing);
        }
    }
}
