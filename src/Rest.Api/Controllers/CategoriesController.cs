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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController(ICategoriesRepository categoriesRepository)
        {
            this._categoriesRepository = categoriesRepository;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _categoriesRepository.Delete(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this._categoriesRepository.Get(id));
        }

        [HttpGet]
        public async Task<IEnumerable<CategoriesDto>> Get()
        {
            var categories = await _categoriesRepository.GetAll();
            var result = categories.Select(s => (CategoriesDto)s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoriesDto categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _categoriesRepository.Insert(categories);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CategoriesDto categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _categoriesRepository.Update(categories));
        }
    }
}
