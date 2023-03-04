using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Commands.CreatePerson;
using OnionArchitecture.Application.Features.Queriers.GetAllPerson;
using OnionArchitecture.Application.Features.Queries.GetPersonById;
using OnionArchitecture.Application.Parameters;

namespace OnionArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IMediator Mediator;
        public PersonController(IMediator mediator)
        {
            this.Mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllPerson")]
        public async Task<IActionResult> GetAllPerson([FromQuery]RequestParameter request)
        {
            var query = new GetAllPersonQuery() { RequestParameter = request  };
            return Ok(await Mediator.Send(query));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetPersonByIdQuery() { Id = id };
            return Ok(await Mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePersonCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
