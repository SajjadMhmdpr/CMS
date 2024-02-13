using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IMyGenericRepository<TEntity> where TEntity : class
    {
        TEntity getByID(object id);
        void insert(TEntity t);
        void update(TEntity t);
        IEnumerable<TEntity> getAll( string includes = "",Expression<Func<TEntity, bool>> where = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        void delete(TEntity t);
        void delete(object id);
        void save();
    }


}
