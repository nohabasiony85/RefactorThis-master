using MediatR;

namespace RefactorThis.Domain.Abstractions;

public interface IQuery<TResponse> : IRequest<TResponse>
{
    
}