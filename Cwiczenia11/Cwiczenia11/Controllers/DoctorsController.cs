using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.DTO.Requests;
using Cwiczenia11.Models;
using Cwiczenia11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public DoctorsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetDoctors(int id)
        {
            var response = _dbService.GetDoctor(id);
            
            if(response != null)
                return Ok(response);

            return NotFound("Doktor o podanym id nie istnieje");
        }

        [HttpPost("add")]
        public IActionResult AddDoctor(AddDoctorRequest request)
        {
            var response = _dbService.AddDoctor(request);

            if(response != null)
                return Created("", response);

            return BadRequest();
        }

        [HttpPost("{id:int}/modify")]
        public IActionResult ModifyDoctor(int id, ModifyDoctorRequest request)
        {
            var response = _dbService.ModifyDoctor(id, request);

            if(response != null)
                return Ok(response);

            return BadRequest();
        }

        [HttpDelete("{id:int}/delete")]
        public IActionResult DeleteDoctor(int id)
        {
            var response = _dbService.DeleteDoctor(id);

            if(response != null)
                return Ok(response);

            return NotFound();
        }
    }
}