using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.Login.LoginQuery;

public record LoginQuery(string UserName, string Password) : IQuery<LoginQueryResponse>;