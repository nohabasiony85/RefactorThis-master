using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Application.Products.GetProductsByNameQuery;

public class GetProductsByNameQueryHandler : IQueryHandler<GetProductsByNameQuery, Product>
{
    public Task<Product> Handle(GetProductsByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}