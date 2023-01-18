using Infrastructure.DataAccess.Repositories;
using Infrastructure.DataAccess.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DataAccess.Abstract;
using Vektorel.DataAccess.Concrete.EntityFramework.Context;
using Vektorel.Model.Entities;

namespace Vektorel.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfProductRepository : EFGenericRepository<Product, NorthwndContext>, IProductDal
    {
        
    }
}
