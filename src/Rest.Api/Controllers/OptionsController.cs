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
    public class OptionsController : ControllerBase
    {
        private readonly IOptionsRepository _optionsRepository;

        public OptionsController(IOptionsRepository optionsRepository)
        {
            this._optionsRepository = optionsRepository;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await _optionsRepository.Delete(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this._optionsRepository.Get(id));
        }

        [HttpGet]
        public async Task<IEnumerable<OptionsDto>> Get()
        {
            var options = await _optionsRepository.GetAll();
            var result = options.Select(s => (OptionsDto)s).ToList();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OptionsDto options)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _optionsRepository.Insert(options);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] OptionsDto options)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(await _optionsRepository.Update(options));
        }
    }
}
