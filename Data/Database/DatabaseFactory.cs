using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSite.Data
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private SiteDbContext _dataContext;
        public SiteDbContext Get()
        {
            return _dataContext ?? (_dataContext = new SiteDbContext());
        }
        public override void DisposeCore()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}
