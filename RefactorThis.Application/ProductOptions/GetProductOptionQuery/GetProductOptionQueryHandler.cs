using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.ProductOptions.GetProductOptionQuery;

public class GetProductOptionQueryHandler : IQueryHandler<GetProductOptionQuery, ProductOption>
{
    public Task<ProductOption> Handle(GetProductOptionQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}