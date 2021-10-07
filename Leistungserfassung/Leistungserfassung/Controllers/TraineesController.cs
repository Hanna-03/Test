using DataLib.Modell;
using Leistungserfassung.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Leistungserfassung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {
        private readonly DBService<Trainee> _traineeService;

        public TraineesController(DBService<Trainee> traineeService)
        {
            _traineeService = traineeService;
        }

        [HttpGet]
        public ActionResult<List<Trainee>> Get() =>
            _traineeService.Get();

        [HttpGet("{id:length(24)}", Name = "GetTrainee")]
        public ActionResult<Trainee> Get(Guid id)
        {
            var trainee = _traineeService.Get(id);

            if (trainee == null)
            {
                return NotFound();
            }

            return trainee;
        }

        [HttpPost]
        public ActionResult<Trainee> Create(Trainee trainee)
        {
            _traineeService.Create(trainee);

            return CreatedAtRoute("GetTrainee", new { id = trainee.Id.ToString() }, trainee);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(Guid id, Trainee traineeIn)
        {
            var trainee = _traineeService.Get(id);

            if (trainee == null)
            {
                return NotFound();
            }

            _traineeService.Update(id, traineeIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(Guid id)
        {
            var trainee = _traineeService.Get(id);

            if (trainee == null)
            {
                return NotFound();
            }

            _traineeService.Remove(trainee.Id);

            return NoContent();
        }
    }
}
