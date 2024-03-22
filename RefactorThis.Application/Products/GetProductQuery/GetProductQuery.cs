using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Products.GetProductQuery;

public record GetProductQuery(Guid ProductId) : IQuery<Product>;