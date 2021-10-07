using DataLib.Modell;
using Leistungserfassung.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Leistungserfassung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly DBService<Test> _testService;

        public TestsController(DBService<Test> testService)
        {
            _testService = testService;
        }

        [HttpGet]
        public ActionResult<List<Test>> Get() =>
            _testService.Get();

        [HttpGet("{id:length(24)}", Name = "GetTest")]
        public ActionResult<Test> Get(Guid id)
        {
            var test = _testService.Get(id);

            if (test == null)
            {
                return NotFound();
            }

            return test;
        }

        [HttpPost]
        public ActionResult<Test> Create(Test test)
        {
            _testService.Create(test);

            return CreatedAtRoute("GetBook", new { id = test.Id.ToString() }, test);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(Guid id, Test testIn)
        {
            var test = _testService.Get(id);

            if (test == null)
            {
                return NotFound();
            }

            _testService.Update(id, testIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(Guid id)
        {
            var test = _testService.Get(id);

            if (test == null)
            {
                return NotFound();
            }

            _testService.Remove(test.Id);

            return NoContent();
        }
    }
}
