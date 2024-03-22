using MediatR;

namespace RefactorThis.Application.Abstractions;

public interface IQuery<TResponse> : IRequest<TResponse>
{
    
}