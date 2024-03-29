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
    public class TablesController : ControllerBase
    {
        private readonly ITablesRepository _tablesRepository;

        public TablesController(ITablesRepository tablesRepository)
        {
            _tablesRepository = tablesRepository;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _tablesRepository.Delete(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this._tablesRepository.Get(id));
        }

        [HttpGet]
        public async Task<IEnumerable<TablesDto>> Get()
        {
            var tables = await _tablesRepository.GetAll();
            var result = tables.Select(s => (TablesDto) s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TablesDto tables)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _tablesRepository.Insert(tables);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] TablesDto tables)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _tablesRepository.Update(tables));
        }
    }
}