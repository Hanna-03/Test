using DataLib.Modell;
using Leistungserfassung.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Leistungserfassung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly DBService<Result> _resultService;

        public ResultsController(DBService<Result> resultService)
        {
            _resultService = resultService;
        }

        [HttpGet]
        public ActionResult<List<Result>> Get() =>
            _resultService.Get();

        [HttpGet("{id:length(24)}", Name = "GetResult")]
        public ActionResult<Result> Get(Guid id)
        {
            var result = _resultService.Get(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPost]
        public ActionResult<Result> Create(Result result)
        {
            _resultService.Create(result);

            return CreatedAtRoute("GetResult", new { id = result.Id.ToString() }, result);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(Guid id, Result resultIn)
        {
            var result = _resultService.Get(id);

            if (result == null)
            {
                return NotFound();
            }

            _resultService.Update(id, resultIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(Guid id)
        {
            var result = _resultService.Get(id);

            if (result == null)
            {
                return NotFound();
            }

            _resultService.Remove(result.Id);

            return NoContent();
        }
    }
}
