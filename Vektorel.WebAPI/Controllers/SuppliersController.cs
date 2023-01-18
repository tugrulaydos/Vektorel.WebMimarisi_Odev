using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vektorel.Business.Abstract;
using Vektorel.DataAccess.Abstract;
using Vektorel.Model.Entities;

namespace Vektorel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {

        private readonly ISupplierService _supplierService;




        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet("getall")]
        public List<Supplier> GetAllProducts()
        {


            //ProductManager productManager = new ProductManager(new AdoNetProductRepository());
            //var products = productManager.GetAllProducts();

            //var products = _productService.GetAllProducts();

            //NorthwndContext context = new NorthwndContext();
            //var products = context.Products.Include("Category").ToList();



            var suppliers = _supplierService.GetAllSuppliers();
            
            return suppliers;
        }




    }
}
