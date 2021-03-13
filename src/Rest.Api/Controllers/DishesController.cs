using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.Repositories.Contracts;

namespace Rest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishesRepository _dishesRepository;

        public DishesController(IDishesRepository dishesRepository)
        {
            this._dishesRepository = dishesRepository;
        }

        [HttpDelete("{idDish}")]
        public async Task<ActionResult> Delete(int idDish)
        {
            return Ok(await _dishesRepository.Delete(idDish));
        }

        [HttpGet]
        public async Task<IEnumerable<DishesDto>> Get()
        {
            var dishes = await _dishesRepository.GetAll();
            var result = dishes.Select(s => (DishesDto)s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DishesDto dishes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _dishesRepository.Insert(dishes);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] DishesDto dishes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _dishesRepository.Update(dishes));
        }
    }
}
