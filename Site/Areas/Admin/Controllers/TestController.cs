using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;
using WebSite.Data;

namespace Site.Areas.Admin.Controllers
{
    public partial class TestController : Controller
    {
        private SiteDbContext db = new SiteDbContext();

        //
        // GET: /Admin/Test/

        public virtual ActionResult Index()
        {
            var category = db.Category.Include(c => c.Section);
            return View(category.ToList());
        }

        //
        // GET: /Admin/Test/Details/5

        public virtual ActionResult Details(int id = 0)
        {
            Category category = db.Category.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        //
        // GET: /Admin/Test/Create

        public virtual ActionResult Create()
        {
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Name");
            return View();
        }

        //
        // POST: /Admin/Test/Create

        [HttpPost]
        public virtual ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Category.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Name", category.SectionId);
            return View(category);
        }

        //
        // GET: /Admin/Test/Edit/5

        public virtual ActionResult Edit(int id = 0)
        {
            Category category = db.Category.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Name", category.SectionId);
            return View(category);
        }

        //
        // POST: /Admin/Test/Edit/5

        [HttpPost]
        public virtual ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Name", category.SectionId);
            return View(category);
        }

        //
        // GET: /Admin/Test/Delete/5

        public virtual ActionResult Delete(int id = 0)
        {
            Category category = db.Category.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        //
        // POST: /Admin/Test/Delete/5

        [HttpPost, ActionName("Delete")]
        public virtual ActionResult DeleteConfirmed(int id)
        {
            Category category = db.Category.Find(id);
            db.Category.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}