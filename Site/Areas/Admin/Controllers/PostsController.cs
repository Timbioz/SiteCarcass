using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Areas.Admin.Controllers
{
    public partial class PostsController : BaseController
    {
        //
        // GET: /Admin/Posts/

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Create()
        {
            
            return View();
        }
    }
}
