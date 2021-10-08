using DataLib.Modell;
using Leistungserfassung.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Leistungserfassung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly DBService<Instructor> _instructorService;

        public InstructorsController(DBService<Instructor> instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet]
        public ActionResult<List<Instructor>> Get() =>
            _instructorService.Get();

        [HttpGet("{id:length(24)}", Name = "GetInstructor")]
        public ActionResult<Instructor> Get(Guid id)
        {
            var instructor = _instructorService.Get(id);

            if (instructor == null)
            {
                return NotFound();
            }

            return instructor;
        }

        [HttpPost]
        public ActionResult<Instructor> Create(Instructor instructor)
        {
            _instructorService.Create(instructor);

            return CreatedAtRoute("GetInstructor", new { id = instructor.Id.ToString() }, instructor);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(Guid id, Instructor instructorIn)
        {
            var instructor = _instructorService.Get(id);

            if (instructor == null)
            {
                return NotFound();
            }

            _instructorService.Update(id, instructorIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(Guid id)
        {
            var instructor = _instructorService.Get(id);

            if (instructor == null)
            {
                return NotFound();
            }

            _instructorService.Remove(instructor.Id);

            return NoContent();
        }
    }
}
