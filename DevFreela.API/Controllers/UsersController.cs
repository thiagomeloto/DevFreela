using DevFreela.Application.InputModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;            
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _mediator.Send(id);

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewUserInputModel createUserModel)
        {
            _mediator.Send(createUserModel);

            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }        
    }
}
