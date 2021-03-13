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
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantsRepository _restaurantsRepository;
        private readonly IMenusRepository _menusRepository;

        public RestaurantsController(IRestaurantsRepository restaurantsRepository, IMenusRepository menusRepository)
        {
            _restaurantsRepository = restaurantsRepository;
            _menusRepository = menusRepository;
        }

        [HttpDelete("{idRestaurant}")]
        public async Task<ActionResult> Delete(int idRestaurant)
        {
            return Ok(await _restaurantsRepository.Delete(idRestaurant));
        }

        [HttpGet]
        public async Task<IEnumerable<RestaurantsDto>> Get()
        {
            var restaurants = await _restaurantsRepository.GetAll();
            var result = restaurants.Select(s => (RestaurantsDto) s).ToList();
            return result;
        }

        [HttpGet("{idRestaurant}/[Action]")]
        public async Task<IActionResult> Menus(int idRestaurant)
        {
            return Ok(await _menusRepository.List(p =>
                p.RestaurantsMenus.Select(s => s.IdRestaurant).Contains(idRestaurant)));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RestaurantsDto restaurants)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _restaurantsRepository.Insert(restaurants);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] RestaurantsDto restaurants)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _restaurantsRepository.Update(restaurants));
        }
    }
}