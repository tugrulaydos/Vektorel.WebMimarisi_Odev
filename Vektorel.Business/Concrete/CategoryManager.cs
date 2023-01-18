using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Business.Abstract;
using Vektorel.DataAccess.Abstract;
using Vektorel.Model.Entities;

namespace Vektorel.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        
        public List<Category> GetCategories(Expression<Func<Category, bool>> expression = null)
        {
            return _categoryDal.GetAll(expression);
        }
    }
}
