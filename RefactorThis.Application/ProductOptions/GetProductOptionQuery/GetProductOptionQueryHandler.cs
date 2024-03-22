using RefactorThis.Domain.Abstractions;
using RefactorThis.Domain.Models;

namespace RefactorThis.Application.ProductOptions.GetProductOptionQuery;

public class GetProductOptionQueryHandler : IQueryHandler<GetProductOptionQuery, ProductOption>
{
    public Task<ProductOption> Handle(GetProductOptionQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}