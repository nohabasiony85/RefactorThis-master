using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Application.Products.GetProductsByNameQuery;

public record GetProductsByNameQuery(string Name) : IQuery<Product>;