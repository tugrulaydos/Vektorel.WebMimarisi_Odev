using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DataAccess.Abstract;
using Vektorel.Model.Entities;

namespace Vektorel.Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private readonly ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public List<Supplier> GetAllSuppliers(Expression<Func<Supplier, bool>> predicate = null, params Expression<Func<Supplier, object>>[] includeEntities)
        {
            return _supplierDal.GetAll(predicate,includeEntities);
        }
    }
}
