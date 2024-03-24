using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Login.LoginQuery;

public class LoginQueryHandler : IQueryHandler<LoginQuery, Product>
{
    public Task<Product> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}