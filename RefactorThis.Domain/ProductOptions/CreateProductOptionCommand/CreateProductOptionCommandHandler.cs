using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.ProductOptions.CreateProductOptionCommand;

public class CreateProductOptionCommandHandler : ICommandHandler<CreateProductOptionRequest, Guid>
{
    public Task<Guid> Handle(CreateProductOptionRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}