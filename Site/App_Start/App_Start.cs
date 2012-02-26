using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebSite.Data;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Site.AppStart), "Start")]

namespace Site
{
    public static class AppStart
    {
        public static void Start()
        {
            Database.SetInitializer<SiteDbContext>(new FakeDatabase());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SiteDbContext>());
        }
    }
}