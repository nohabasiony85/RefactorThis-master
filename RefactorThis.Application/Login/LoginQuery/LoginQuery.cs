using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Login.LoginQuery;

public record LoginQuery(string UserName, string Password) : IQuery<Product>;