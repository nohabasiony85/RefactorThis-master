using RefactorThis.Domain.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Domain.Products.GetProductsByNameQuery;

public record GetProductsByNameQuery(string Name) : IQuery<Product>;