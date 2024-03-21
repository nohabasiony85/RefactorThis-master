using MediatR;

namespace RefactorThis.Domain.Products.CreateProductCommand;

public record CreateProductCommand(string RequestName, string RequestDescription, decimal RequestPrice, decimal RequestDeliveryPrice) : IRequest<CreateProductResponse>;