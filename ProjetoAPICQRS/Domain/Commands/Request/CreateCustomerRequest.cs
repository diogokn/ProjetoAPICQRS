using MediatR;
using ProjetoAPICQRS.Commands.Response;

namespace ProjetoAPICQRS.Commands.Request
{
    public class CreateCustomerRequest: IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
