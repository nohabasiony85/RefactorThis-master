using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Application.ProductOptions.GetProductOptionQuery;

public record GetProductOptionQuery(int ProductOptionId) : IQuery<ProductOption>;