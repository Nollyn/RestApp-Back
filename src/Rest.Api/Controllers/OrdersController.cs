using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersController(IOrdersRepository ordersRepository)
        {
            this._ordersRepository = ordersRepository;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _ordersRepository.Delete(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this._ordersRepository.Get(id));
        }

        [HttpGet]
        public async Task<IEnumerable<OrdersDto>> Get()
        {
            var orders = await _ordersRepository.GetAll();
            var result = orders.Select(s => (OrdersDto)s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OrdersDto orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _ordersRepository.Insert(orders);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] OrdersDto orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _ordersRepository.Update(orders));
        }
    }
}
