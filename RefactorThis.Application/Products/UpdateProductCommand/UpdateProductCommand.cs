using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.Products.UpdateProductCommand;

public record UpdateProductCommand(Guid Id, string Name, string Description, decimal Price, decimal DeliveryPrice)
    : ICommand;