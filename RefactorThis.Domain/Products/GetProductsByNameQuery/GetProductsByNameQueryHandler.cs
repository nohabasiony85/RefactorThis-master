using RefactorThis.Domain.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Domain.Products.GetProductsByNameQuery;

public class GetProductsByNameQueryHandler : IQueryHandler<GetProductsByNameQuery, Product>
{
    public Task<Product> Handle(GetProductsByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}