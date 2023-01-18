using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Model.Entities;

namespace Vektorel.DataAccess.Abstract
{
    public interface ISupplierService
    {
        public List<Supplier> GetAllSuppliers(Expression <Func<Supplier, bool>> predicate = null, params Expression<Func<Supplier, object>>[] includeEntities);        

       
      
    }
}
