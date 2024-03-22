using RefactorThis.Domain.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Application.Products.GetProductQuery;

public record GetProductQuery(Guid ProductId) : IQuery<Product>;