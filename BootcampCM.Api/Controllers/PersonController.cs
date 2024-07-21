using BootcampCM.Api.Models.Requests;
using BootcampCM.Api.Operations.Commands;
using BootcampCM.Api.Operations.Queries;
using BootcampCM.Domain.Interfaces;
using BootcampCM.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BootcampCM.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        public async Task<IActionResult> Add(CreatePersonRequest request)
        {
            var command = await _mediator.Send(new CreatePersonCommand(request.Name, request.Age, request.TaxId));

            return Ok(command);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllPeopleQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeletePersonCommand(id);
            var result = await _mediator.Send(command);
            if (result) return NoContent();
            return Ok();
        }
    }
}
