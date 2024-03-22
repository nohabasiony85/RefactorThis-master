using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Application.CreateProductCommand;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Guid>
{
    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}