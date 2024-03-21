using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.CreateProductCommand;

public record CreateProductRequest(string Name, string Description ,decimal Price , decimal DeliveryPrice) : ICommand<Guid>;