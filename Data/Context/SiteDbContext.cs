using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Data.Entity;
using WebSite.Models;

namespace WebSite.Data
{
    public class SiteDbContext : DbContext
    {
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Sections> Sections { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Ratings> Ratings { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
