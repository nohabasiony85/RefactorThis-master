using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Application.ProductOptions.CreateProductOptionCommand;

public class CreateProductOptionCommandHandler : ICommandHandler<CreateProductOptionCommand, Guid>
{
    public Task<Guid> Handle(CreateProductOptionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}