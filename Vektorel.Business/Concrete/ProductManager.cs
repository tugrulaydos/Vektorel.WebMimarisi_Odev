using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Business.Abstract;
using Vektorel.DataAccess.Abstract;
using Vektorel.DataAccess.Concrete.EntityFramework.Repositories;
using Vektorel.Model.Entities;

namespace Vektorel.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager()
        {
            _productDal = new EfProductRepository();
        }

        public List<Product> GetAllProducts(Expression<Func<Product, bool>> expression = null, string includeEntity = null)
        {
            return _productDal.GetAll(expression, includeEntity);
        }
    }
}
