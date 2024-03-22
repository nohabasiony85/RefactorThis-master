using RefactorThis.Domain.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Application.Products.GetProductQuery;

public class GetProductQueryHandler : IQueryHandler<GetProductQuery, Product>
{
    public Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}