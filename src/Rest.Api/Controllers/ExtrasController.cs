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
    public class ExtrasController : ControllerBase
    {
        private readonly IExtrasRepository _extrasRepository;

        public ExtrasController(IExtrasRepository extrasRepository)
        {
            this._extrasRepository = extrasRepository;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _extrasRepository.Delete(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this._extrasRepository.Get(id));
        }

        [HttpGet]
        public async Task<IEnumerable<ExtrasDto>> Get()
        {
            var extras = await _extrasRepository.GetAll();
            var result = extras.Select(s => (ExtrasDto)s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ExtrasDto extras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _extrasRepository.Insert(extras);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ExtrasDto extras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _extrasRepository.Update(extras));
        }
    }
}
