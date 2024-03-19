using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.DeleteProductCommand;

public record DeleteProductCommand() : ICommand<Guid>;