using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Application.Products.DeleteProductCommand;

public record DeleteProductCommand() : ICommand<Guid>;