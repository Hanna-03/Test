using DataLib.Modell;
using Leistungserfassung.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Leistungserfassung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly DBService<Class> _classService;

        public ClassesController(DBService<Class> classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public ActionResult<List<Class>> Get() =>
            _classService.Get();

        [HttpGet("{id:length(24)}", Name = "GetClass")]
        public ActionResult<Class> Get(Guid id)
        {
            var _class = _classService.Get(id);

            if (_class == null)
            {
                return NotFound();
            }

            return _class;
        }

        [HttpPost]
        public ActionResult<Class> Create(Class _class)
        {
            _classService.Create(_class);

            return CreatedAtRoute("GetClass", new { id = _class.Id.ToString() }, _class);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(Guid id, Class classIn)
        {
            var _class = _classService.Get(id);

            if (_class == null)
            {
                return NotFound();
            }

            _classService.Update(id, classIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(Guid id)
        {
            var _class = _classService.Get(id);

            if (_class == null)
            {
                return NotFound();
            }

            _classService.Remove(_class.Id);

            return NoContent();
        }
    }
}
