using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;
using WebSite.Core;


namespace Site.Areas.Admin.Controllers
{
    public partial class BaseController : Controller
    {
        private readonly IConfigService configService;

        public BaseController(IConfigService configService)
        {
            this.configService = configService;
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var model = ViewData.Model as BaseViewModel;

            if (model != null)
            {
                //model.WithSettings(configService.GetAllSettings());
            }

            base.OnActionExecuted(filterContext);
        }
    }
}
