using Microsoft.AspNetCore.Mvc;
using ProductLib;
using System.Diagnostics;

namespace CatalogAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        /*  public ProductsController()
          {
          }
        */

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            List<Product> products = ProductManager.GetAllProducts();
            return products;
        }
    }
}
