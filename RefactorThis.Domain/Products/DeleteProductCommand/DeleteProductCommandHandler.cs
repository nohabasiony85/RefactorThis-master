using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.DeleteProductCommand;

public class CreateProductCommandHandler : ICommandHandler<Products.CreateProductCommand.CreateProductCommand, Guid>
{
    public Task<Guid> Handle(Products.CreateProductCommand.CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}