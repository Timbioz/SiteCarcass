using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Areas.Admin.Controllers
{
    public partial class CategoriesController : BaseController
    {
        //
        // GET: /Admin/Categories/

        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
