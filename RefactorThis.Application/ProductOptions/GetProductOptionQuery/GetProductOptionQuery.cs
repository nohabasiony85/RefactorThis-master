using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.ProductOptions.GetProductOptionQuery;

public record GetProductOptionQuery(Guid ProductId) : IQuery<ProductOption>;