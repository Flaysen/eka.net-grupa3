using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventer.AspNetCore.Services;
using Eventer.Domain.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Eventer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly IEventService _eventServices;

        public EventController(IEventService eventServices)
        {
            
            _eventServices = eventServices;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            return new JsonResult(_eventServices.GetEvents());
        }
        [HttpGet("{id}")]
        public IActionResult GetEvent(int id)
        {
            var eventDto = _eventServices.GetEvent(id);
            if (eventDto != null)
            {
                return new JsonResult(eventDto);
            }

            return BadRequest();
        }

        [HttpPost]
        public IActionResult AddEvent([FromBody]AddEventDto eventDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _eventServices.AddEvent(eventDto);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateEvent([FromBody] UpdateEventDto eventDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _eventServices.UpdateEvent(eventDto);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(int id)
        {
            var task = _eventServices.GetEvent(id);
            if (task == null)
            {
                return BadRequest();
            }

            _eventServices.DeleteEvent(id);
            return Ok();
        }
    }
}
