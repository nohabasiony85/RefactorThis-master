using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Products.GetProductsByNameQuery;

public record GetProductsByNameQuery(string Name) : IQuery<Product>;