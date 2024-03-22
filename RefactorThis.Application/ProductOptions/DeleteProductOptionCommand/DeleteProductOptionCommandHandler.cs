using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Application.ProductOptions.DeleteProductOptionCommand;

public class DeleteProductOptionCommandHandler : ICommandHandler<DeleteProductOptionCommand, Guid>
{
    public Task<Guid> Handle(DeleteProductOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}