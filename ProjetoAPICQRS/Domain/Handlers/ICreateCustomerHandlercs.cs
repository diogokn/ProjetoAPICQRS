using ProjetoAPICQRS.Commands.Request;
using ProjetoAPICQRS.Commands.Response;

namespace ProjetoAPICQRS.Domain.Handlers
{
    //Com o Mediator não será preciso
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
