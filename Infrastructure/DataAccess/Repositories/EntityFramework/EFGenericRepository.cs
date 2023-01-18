using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Repositories.EntityFramework
{
    public class EFGenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, string includeEntity = null)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> dbSet = context.Set<TEntity>();

                if (includeEntity != null)
                {
                    dbSet = dbSet.Include(includeEntity);
                }

                // dbSet = dbSet.Include(includeEntity);
                // dbSet = dbSet.Include(includeEntity);

                return predicate == null
                    ? dbSet.ToList()
                    : dbSet.Where(predicate).ToList();
            }
            
        }
    }
}
