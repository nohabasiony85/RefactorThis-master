using RefactorThis.Domain.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Domain.ProductOptions.GetProductOptionQuery;

public record GetProductOptionQuery(int productOptionId) : IQuery<ProductOption>;