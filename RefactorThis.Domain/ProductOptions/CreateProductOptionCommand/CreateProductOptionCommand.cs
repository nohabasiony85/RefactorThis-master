using MediatR;
using RefactorThis.Domain.Abstractions;
using RefactorThis.Domain.Products.CreateProductCommand;

namespace RefactorThis.Domain.ProductOptions.CreateProductOptionCommand;

public record CreateProductOptionCommand(Guid ProductId, string Name, string Description) : IRequest<CreateProductOptionResponse>;