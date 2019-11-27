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
    [Produces("application/json")]
    [Route("api/TestModel")]
    [ApiController]
    public class TestModelController : ControllerBase
    {
        private readonly ITestModelService _testModelServices;

        public TestModelController(ITestModelService testModelServices)
        {

            _testModelServices = testModelServices;
        }

        [Route("~/api/GetTestModel")]
        [HttpGet]
        public IActionResult GetTestModel(int id)
        {
            var testModelDto = _testModelServices.GetTestModel(id);
            if (testModelDto != null)
            {
                return new JsonResult(testModelDto);
            }

            return BadRequest();
        }

        [Route("~/api/AddTestModel")]
        [HttpPost]
        public IActionResult AddTestModel([FromBody]AddTestModelDto testModelDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _testModelServices.AddTestModel(testModelDto);
            return Ok();
        }
    }
}