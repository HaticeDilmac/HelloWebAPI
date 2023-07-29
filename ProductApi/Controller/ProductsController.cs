using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controller
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Burada kullanılan Logger bir tür interface
        private readonly ILogger<ProductsController> _logger;
        //Bir ifade eğer readonly olarak tanımlanmışsa;
        //Const. 2. Tanımlandığı yer

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        //Bu iki ifadeye dependence injection



         [HttpGet]
         public IActionResult GetAllProducts()
         {
               var products = new List<Product>() {
               new Product(){Id=1,ProductName="Computer"},
               new Product(){Id=2,ProductName="Keyboard"},
               new Product(){Id=3,ProductName="Mouse"},
         };
            _logger.LogInformation("Get All production");
            return Ok(products);//Products listesini döndürüyor.
        }
    }
}
