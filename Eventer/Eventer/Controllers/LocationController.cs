using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventer.AspNetCore.Services;
using Eventer.Domain.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Eventer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocationService _locationServices;

        public LocationController(ILocationService locationService)
        {
            _locationServices = locationService;
        }

        [HttpGet]
        public IActionResult GetLocations()
        {
            return new JsonResult(_locationServices.GetLocations());
        }

        [HttpGet("{id}")]
        public IActionResult GetLocation(int id)
        {
            var locationDto = _locationServices.GetLocation(id);
            if (locationDto != null)
            {
                return new JsonResult(locationDto);
            }

            return BadRequest();
        }
        [HttpPost]
        public IActionResult AddEvent([FromBody]AddLocationDto locationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _locationServices.AddLocation(locationDto);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult DeleteLocation(int id)
        {
            var task = _locationServices.GetLocation(id);
            if (task == null)
            {
                return BadRequest();
            }
            _locationServices.DeleteLocation(id);
            return Ok();
        }
        
        public IActionResult UpdateLocation([FromBody] UpdateLocationDto locationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _locationServices.UpdateLocation(locationDto);
            return Ok();
        }
       
    }
}