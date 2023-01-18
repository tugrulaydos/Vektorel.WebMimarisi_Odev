using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Model.Entities;

namespace Vektorel.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllProducts(Expression<Func<Product, bool>> expression = null, string includeEntity = null);
    }
}
