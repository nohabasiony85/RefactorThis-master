using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.CreateProductCommand;

public record CreateProductCommand() : ICommand<Guid>;