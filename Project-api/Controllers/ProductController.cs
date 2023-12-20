using Microsoft.AspNetCore.Mvc;
using Project.Core.Models;
using Project.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _products;

        public ProductController(IProductServices ProductService)
        {
            _products = ProductService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products.GetAll();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _products.Get(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product prod)
        {
            _products.Post(prod);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product prod)
        {
            _products.Put(id, prod);    
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _products.Delete(id);
        }
    }
}
