using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Products.GetProductQuery;

public record GetProductQuery(Guid Id, string Name, string Description ,decimal Price , decimal DeliveryPrice) : IQuery<Product>;