using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.Products.CreateProductCommand;

public record CreateProductRequest(string Name, string Description ,decimal Price , decimal DeliveryPrice) : ICommand<Guid>;