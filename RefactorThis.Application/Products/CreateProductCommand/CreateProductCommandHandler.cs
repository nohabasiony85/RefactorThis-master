using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Application.Products.CreateProductCommand;

public class CreateProductCommandHandler : ICommandHandler<Products.CreateProductCommand.CreateProductCommand, Guid>
{
    public async Task<Guid> Handle(Products.CreateProductCommand.CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}