using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WebSite.Data
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        int Count();
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, Boolean>> where);
        T GetById(long id);
        T GetById(string id);
        T Get(Func<T, Boolean> where);
        List<T> Get(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, string includeProperties);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
