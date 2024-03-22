using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.Products.CreateProductCommand;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Guid>
{
    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}