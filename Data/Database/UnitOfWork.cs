using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSite.Data
{
    public class UnitOfWork : Disposable, IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private SiteDbContext dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected SiteDbContext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.Commit();
        }

        public override void DisposeCore()
        {
            if(DataContext != null)
                DataContext.Dispose();
        }
    }
}
