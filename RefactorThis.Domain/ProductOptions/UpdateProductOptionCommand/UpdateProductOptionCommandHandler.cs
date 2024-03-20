using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.ProductOptions.UpdateProductOptionCommand;

public class UpdateProductOptionCommandHandler : ICommandHandler<UpdateProductOptionCommand, Guid>
{
    public Task<Guid> Handle(UpdateProductOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}