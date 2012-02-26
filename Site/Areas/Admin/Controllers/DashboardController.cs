using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Areas.Admin.Controllers
{
    public partial class DashboardController : BaseController
    {
        //
        // GET: /Admin/Dashboard/

        public virtual ActionResult Index()
        {
            return View();
        }

       

    }
}
