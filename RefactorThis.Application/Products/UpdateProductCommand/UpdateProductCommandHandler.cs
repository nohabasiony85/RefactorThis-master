using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.Products.UpdateProductCommand;

public class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, Guid>
{
    public Task<Guid> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}