using FizzBuzz;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FizzBuzz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            this.fizzBuzzService = fizzBuzzService;
        }

        [HttpPost]
        public ActionResult<IEnumerable<string>> CalculateFizzBuzz([FromBody] FizzBuzzRequest request)
        {
            if (request == null || request.InputArray == null)
            {
                return BadRequest("Invalid request. Please provide an array of values.");
            }

            var results = fizzBuzzService.CalculateFizzBuzz(request.InputArray);
            return Ok(results);
        }
    }
}
