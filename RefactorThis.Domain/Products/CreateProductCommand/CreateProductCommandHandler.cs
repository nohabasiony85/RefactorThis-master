using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.CreateProductCommand;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Guid>
{
    public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}