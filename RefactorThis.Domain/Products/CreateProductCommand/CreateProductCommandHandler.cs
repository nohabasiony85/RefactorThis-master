using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.CreateProductCommand;

public class CreateProductCommandHandler : ICommandHandler<CreateProductRequest, Guid>
{
    public Task<Guid> Handle(CreateProductRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}