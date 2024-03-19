using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.DeleteProductCommand;

public record CreateProductCommand() : ICommand<Guid>;