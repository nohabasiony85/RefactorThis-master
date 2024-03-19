using RefactorThis.Domain.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Domain.Products.GetProductQuery;

public record GetProductQuery(int productId) : IQuery<Product>;