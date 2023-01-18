using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vektorel.Business.Abstract;
using Vektorel.Business.Concrete;
//using Vektorel.DataAccess.Concrete.AdoNet.Repositories;
using Vektorel.DataAccess.Concrete.EntityFramework.Context;
using Vektorel.DataAccess.Concrete.EntityFramework.Repositories;
using Vektorel.Model.Entities;

namespace Vektorel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet("getall")]
        public List<Product> GetAllProducts()
        {
            //ProductManager productManager = new ProductManager(new AdoNetProductRepository());
            //var products = productManager.GetAllProducts();

            //var products = _productService.GetAllProducts();

            //NorthwndContext context = new NorthwndContext();
            //var products = context.Products.Include("Category").ToList();

            var products = _productService.GetAllProducts(X=>X.ProductId >= 70, "Category");

            return products;
        }
    }
}
