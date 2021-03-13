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
    public class DrinksController : ControllerBase
    {
        private readonly IDrinksRepository _drinksRepository;

        public DrinksController(IDrinksRepository drinksRepository)
        {
            this._drinksRepository = drinksRepository;
        }

        [HttpDelete("{idDrink}")]
        public async Task<ActionResult> Delete(int idDrink)
        {
            return Ok(await _drinksRepository.Delete(idDrink));
        }

        [HttpGet]
        public async Task<IEnumerable<DrinksDto>> Get()
        {
            var drinks = await _drinksRepository.GetAll();
            var result = drinks.Select(s => (DrinksDto)s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DrinksDto drinks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _drinksRepository.Insert(drinks);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] DrinksDto drinks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _drinksRepository.Update(drinks));
        }
    }
}
