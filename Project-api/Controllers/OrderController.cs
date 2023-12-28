using Microsoft.AspNetCore.Mvc;
using Project.Core.Models;
using Project.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {


        private readonly IOrderServices _orders;

        public OrderController(IOrderServices OrderService)
        {
            _orders = OrderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orders.GetAll();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orders.Get(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] Order ordr)
        {
            _orders.Post(ordr);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order ordr)
        {
            _orders.Put(id, ordr);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _orders.Delete(id);
            return NoContent();
        }
    }
}
