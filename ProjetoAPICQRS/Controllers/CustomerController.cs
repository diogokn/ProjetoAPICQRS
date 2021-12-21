using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPICQRS.Commands.Request;
using ProjetoAPICQRS.Commands.Response;
using ProjetoAPICQRS.Domain.Handlers;

namespace ProjetoAPICQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public Task<CreateCustomerResponse> Create(
            [FromServices]IMediator mediator,
            [FromBody]CreateCustomerRequest command
            )
        {
            return mediator.Send(command); 
        }
    }
}
