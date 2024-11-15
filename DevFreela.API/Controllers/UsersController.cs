using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        public UsersController(ExampleClass exampleClass)
        {
                
        }

        [HttpGet("{id}")]
        public IActionResult GetById()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
