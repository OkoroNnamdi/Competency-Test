using Document_Oriented_Database.Models;
using Document_Oriented_Database.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelationDataBaseSystem.Repository;

namespace MyWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase

    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;

        public CustomerController(ICustomerRepository customerRepository, IProductRepository productRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _customerRepository.GetAllAsync();
            return Ok(data);
        }
        // Post: api/customer
        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            await _customerRepository.Create(customer);
            return Ok();

        }
    }
}
