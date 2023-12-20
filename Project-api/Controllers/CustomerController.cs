using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Core.Models;
using Project.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerServices _customers;

        public CustomerController(ICustomerServices custService)
        {
            _customers = custService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult Get(string? text = "")
        {
            return Ok(_customers.GetAll(text));
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customers.Get(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer cust)
        {
            _customers.Post(cust);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer cust)
        {
            _customers.Put(id,cust);

        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customers.Delete( id);
        }
    }
}
