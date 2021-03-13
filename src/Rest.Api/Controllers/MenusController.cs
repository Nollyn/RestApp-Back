﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.Repositories.Contracts;

namespace Rest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMenusRepository _menusRepository;

        public MenusController(IMenusRepository menusRepository)
        {
            _menusRepository = menusRepository;
        }

        [HttpDelete("{idMenu}")]
        public async Task<ActionResult> Delete(int idMenu)
        {
            return Ok(await _menusRepository.Delete(idMenu));
        }

        [HttpGet]
        public async Task<IEnumerable<MenusDto>> Get()
        {
            var extras = await _menusRepository.GetAll();
            var result = extras.Select(s => (MenusDto) s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MenusDto menus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _menusRepository.Insert(menus);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] MenusDto menus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _menusRepository.Update(menus));
        }
    }
}