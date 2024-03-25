using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.Login.LoginQuery;

public record LoginRequest(string UserName, string Password) : ICommand;