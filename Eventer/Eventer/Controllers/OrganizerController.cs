using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eventer.Domain.Models.Dtos;
using Eventer.Domain;
using Eventer.Domain.Models;
using Eventer.AspNetCore.Services;

namespace Eventer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrganizerController : Controller
    {
        private readonly IOrganizerService _organizerServices;

        public OrganizerController(IOrganizerService organizerServices)
        {
            _organizerServices = organizerServices;
        }

        [HttpGet]
        public IActionResult GetOrganizers()
        {
            return new JsonResult(_organizerServices.GetOrganizers());
        }

        [HttpGet("{id}")]
        public IActionResult GetOrganizer(int id)
        {
            var organizerDto = _organizerServices.GetOrganizer(id);
            if (organizerDto != null)
            {
                return new JsonResult(organizerDto);
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult AddOrganizer([FromBody]AddOrganizerDto organizerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _organizerServices.AddOrganizer(organizerDto);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult DeleteOrganizer(int id)
        {
            var task = _organizerServices.GetOrganizer(id);
            if (task == null)
            {
                return BadRequest();
            }
            _organizerServices.DeleteOrganizer(id);
            return Ok();
        }

        [HttpPost]

        public IActionResult UpdateOrganizer([FromBody]UpdateOrganizerDto updateOrganizerDto)
        {
            if (! ModelState.IsValid)
            {
                return BadRequest();
            }
            _organizerServices.UpdateOrganizer(updateOrganizerDto);
            return Ok();
        }

      
    }
}