using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductWebApi.Models;

namespace ProductWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _productDbContext;

        public ProductController(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _productDbContext.Products;
        }

        [HttpGet("{productId:int}")]
        public async Task<ActionResult<Product>> GetById(int productId)
        {
            var products = await _productDbContext.Products.FindAsync(productId);

            return products;
        }

        [HttpPost]
        public async Task<ActionResult> Create(Product product)
        {
            await _productDbContext.Products.AddAsync(product);
            await _productDbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(Product product)
        {
            _productDbContext.Products.Update(product);
            await _productDbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{productId:int}")]
        public async Task<ActionResult<Product>> Delete(int productId)
        {
            var products = await _productDbContext.Products.FindAsync(productId);
            _productDbContext.Products.Remove(products);
            await _productDbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
