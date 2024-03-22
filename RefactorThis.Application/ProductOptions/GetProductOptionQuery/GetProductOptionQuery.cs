using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.ProductOptions.GetProductOptionQuery;

public record GetProductOptionQuery(int ProductOptionId) : IQuery<ProductOption>;