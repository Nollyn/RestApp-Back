using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.Repositories.Contracts;
using Rest.Services.Contracts;

namespace Rest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishesRepository _dishesRepository;
        private readonly IMenusService _menusService;

        public DishesController(IDishesRepository dishesRepository, IMenusService menusService)
        {
            _dishesRepository = dishesRepository;
            _menusService = menusService;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _dishesRepository.Delete(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this._dishesRepository.Get(id));
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

            return Ok(await _menusService.Update(dishes));
        }
    }
}
