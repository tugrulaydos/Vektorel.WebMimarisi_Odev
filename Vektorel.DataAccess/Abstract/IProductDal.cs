using Infrastructure.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Model.Entities;

namespace Vektorel.DataAccess.Abstract
{
    public interface IProductDal : IGenericRepository<Product>
    {

    }
}
