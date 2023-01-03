using Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InMemoryProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public InMemoryProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("inmemorygetallproducts")]
        public IActionResult GetAllProducts()
        {
            var products =_productService.GetProducts();
            return Ok(products);
        }
    }
}
