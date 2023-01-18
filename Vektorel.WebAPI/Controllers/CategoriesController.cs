using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vektorel.Business.Abstract;
using Vektorel.Model.Entities;

namespace Vektorel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public List<Category> GetAllCategories()
        {
            return _categoryService.GetCategories();
        }
    }
}
