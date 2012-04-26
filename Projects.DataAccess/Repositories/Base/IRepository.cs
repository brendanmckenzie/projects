using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Projects.DataAccess.Entities.Base;

namespace Projects.DataAccess.Repositories.Base
{
    public interface IRepository<T> : IDisposable where T : IBaseObject
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T FindById(int id);
        void Add(T entity);
        void Remove(T entity);
        T Create();
        long Count();
        bool Contains(int id);
    }
}