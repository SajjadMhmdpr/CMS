using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application
{
    public class MyGenericRepository<TEntity> : IMyGenericRepository<TEntity> where TEntity : class
    {
        private DB _context;
        private DbSet<TEntity> _dbset;
        public MyGenericRepository(DB context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }

        public virtual TEntity getByID(object id)
        {
            return _dbset.Find(id);

        }

        public virtual void insert(TEntity t)
        {
            _dbset.Add(t);
        }

        public virtual void delete(TEntity t)
        {
            if (_context.Entry(t).State == EntityState.Detached)
                _context.Attach(t);
            _context.Entry(t).State = EntityState.Deleted;
        }

        public virtual void delete(object id)
        {
            var t = getByID(id);
            delete(t);
        }

        public virtual void update(TEntity t)
        {
            if (_context.Entry(t).State == EntityState.Detached)
                _context.Attach(t);
            _context.Entry(t).State = EntityState.Modified;
        }

        public virtual void save()
        {
            _context.SaveChanges();
        }

        //public virtual void Dispose()
        //{
        //: IDisposable
        //    _context.Dispose();
        //}

        public virtual  IEnumerable<TEntity> getAll(string includes = "", Expression<Func<TEntity, bool>> where = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = _dbset;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    query = query.Include(include);
                }
            }

            return query.ToList();
        }

    }
}
