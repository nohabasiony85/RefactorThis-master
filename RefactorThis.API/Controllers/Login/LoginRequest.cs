using RefactorThis.Application.Abstractions;

namespace RefactorThis.Api.Controllers.Login;

public record LoginRequest(string UserName, string Password) : ICommand;