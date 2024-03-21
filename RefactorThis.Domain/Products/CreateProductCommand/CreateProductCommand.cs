using MediatR;

namespace RefactorThis.Domain.Products.CreateProductCommand;

public record CreateProductCommand(string Name, string Description, decimal Price, decimal DeliveryPrice) : IRequest<CreateProductResponse>;