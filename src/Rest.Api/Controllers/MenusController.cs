using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rest.Models;
using Rest.Repositories.Contracts;
using Rest.Services.Contracts;

namespace Rest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMenusRepository _menusRepository;
        private readonly IMenusService _menusService;

        public MenusController(IMenusRepository menusRepository, IMenusService menusService)
        {
            _menusRepository = menusRepository;
            _menusService = menusService;
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _menusRepository.Delete(id));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _menusRepository.GetWithDetails(id);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IEnumerable<MenusDto>> Get()
        {
            var extras = await _menusRepository.GetAll();
            var result = extras.Select(s => (MenusDto)s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MenusDto menus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _menusRepository.InsertAndReturn(menus));
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] MenusDto menus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _menusService.UpdateWithDishes(menus));
        }
    }
}