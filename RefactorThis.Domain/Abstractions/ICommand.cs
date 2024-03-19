using MediatR;

namespace RefactorThis.Domain.Abstractions;

public interface ICommand : IRequest
{
}

public interface ICommand<TResponse> : IRequest<TResponse>
{
}
