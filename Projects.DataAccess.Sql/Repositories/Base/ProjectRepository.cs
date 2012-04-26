﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Projects.DataAccess.Entities.Base;
using Projects.DataAccess.Repositories.Base;
using Projects.DataAccess.Sql.Entities.Base;

namespace Projects.DataAccess.Sql.Repositories.Base
{
    internal class BaseRepository<I, C> : IRepository<I>
        where I : class, IBaseObject
        where C : BaseObject
    {
        private Context _context;

        public BaseRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<I> FindAll()
        {
            return _context.Set<C>().Cast<I>();
        }

        public IEnumerable<I> FindBy(Expression<Func<I, bool>> predicate)
        {
            // TODO: fix this.
            return _context.Set<C>().ToList().Cast<I>().AsQueryable().Where(predicate);
        }

        public I FindById(int id)
        {
            return FindBy(e => e.Id == id).SingleOrDefault();
        }

        public void Add(I entity)
        {
            _context.Set<C>().Add(entity as C);
        }

        public void Remove(I entity)
        {
            _context.Set<C>().Remove(entity as C);
        }

        public I Create()
        {
            return Activator.CreateInstance<C>() as I;
        }

        public long Count()
        {
            return _context.Set<C>().Count();
        }

        public bool Contains(int id)
        {
            return _context.Set<C>().Any(e => e.Id == id);
        }

        public void Dispose()
        {
        }
    }
}