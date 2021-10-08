using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLib.Modell;
using Leistungserfassung.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leistungserfassung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly DBService<Course> _courseService;

        public CoursesController(DBService<Course> courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public ActionResult<List<Course>> Get() =>
            _courseService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCourse")]
        public ActionResult<Course> Get(Guid id)
        {
            var course = _courseService.Get(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        [HttpPost]
        public ActionResult<Course> Create(Course course)
        {
            _courseService.Create(course);

            return CreatedAtRoute("GetCourse", new { id = course.Id.ToString() }, course);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(Guid id, Course courseIn)
        {
            var course = _courseService.Get(id);

            if (course == null)
            {
                return NotFound();
            }

            _courseService.Update(id, courseIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(Guid id)
        {
            var course = _courseService.Get(id);

            if (course == null)
            {
                return NotFound();
            }

            _courseService.Remove(course.Id);

            return NoContent();
        }
    }
}
