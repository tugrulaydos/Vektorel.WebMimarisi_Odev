using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Repositories
{
    public interface IGenericRepository<TEntity>
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, string includeEntity = null);
    }
}
