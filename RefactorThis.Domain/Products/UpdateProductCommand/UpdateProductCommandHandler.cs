using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.UpdateProductCommand;

public class UpdateProductCommandHandler : ICommandHandler<CreateProductCommand.CreateProductCommand, Guid>
{
    public Task<Guid> Handle(CreateProductCommand.CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}