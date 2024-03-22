using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.Products.DeleteProductCommand;

public class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand, Guid>
{
    public Task<Guid> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}