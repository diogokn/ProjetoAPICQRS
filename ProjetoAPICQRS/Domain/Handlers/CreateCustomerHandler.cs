using MediatR;
using ProjetoAPICQRS.Commands.Request;
using ProjetoAPICQRS.Commands.Response;

namespace ProjetoAPICQRS.Domain.Handlers
{
    public class CreateCustomerHandler: IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        //Exemplo sem Mediator
        //public CreateCustomerResponse Handle(CreateCustomerRequest request)
        //{
        //    //TODO Funcionalidades

        //    return new CreateCustomerResponse
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Teste CQRS com Mediator",
        //        Email = "cqrs@mediator.com",
        //        Date = DateTime.Now
        //    };
        //}

        public Task<CreateCustomerResponse> Handle(
            CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Teste CQRS com Mediator",
                Email = "cqrs@mediator.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result); 
        }
    }
}
