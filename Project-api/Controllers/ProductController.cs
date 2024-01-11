using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Core;
using Project.Core.Models;
using Project.Core.Services;
using Project_api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _products;
        private readonly IMapper _mapping;
        public ProductController(IProductServices ProductService ,IMapper mapper)
        {
            _products = ProductService;
            _mapping = mapper;
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
            var products = _products.Get(id);
            var productDto=_mapping.Map<Product>(products);
            return productDto;
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductPostModel prod)
        {
            var product = new Product { Name = prod.Name, OrderId = prod.OrderId };
            return Ok(_products.Post(product));
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product prod)
        {
            _products.Put(id, prod);    
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var prod=_products.Get(id); 
            _products.Delete(id);
            return NoContent();
        }
    }
}
