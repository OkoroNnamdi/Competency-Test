using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelationDataBaseSystem.Model;
using RelationDataBaseSystem.Model.Dto;
using RelationDataBaseSystem.Repository;

namespace MyWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductController> _logger;


        public ProductController(IProductRepository productRepository, ILogger<ProductController> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }
        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct(productDto product)
        {
            try
            {
                var result = await _productRepository.AddProductAsync(product);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding Product");
                return StatusCode(500, "An error occurred while adding the product.");
            }
        }
        [HttpGet("Products")]
        public async Task<IActionResult>GetAllProduct()
        {
            try
            {
                var result = await _productRepository.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting all products");
                return StatusCode(500, "An error occurred while getting all products" +
                    "" +
                    "" +
                    ".");
            }
        }
    }
}
