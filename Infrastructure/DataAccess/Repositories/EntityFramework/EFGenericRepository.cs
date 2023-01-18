using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity,object>>[] includeEntity)
        {
            using (TContext context = new TContext())
            {                        

                IQueryable<TEntity> dbSet = context.Set<TEntity>();

                if(predicate != null)
                {
                    dbSet = dbSet.Where(predicate);
                }

                if (includeEntity.Any())
                {
                    foreach (var item in includeEntity)
                        dbSet = dbSet.Include(item);
                }


                return dbSet.ToList();              


               

            }
            
        }
    }
}
