using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Products.UpdateProductCommand;

public record UpdateProductCommand() : ICommand<Guid>;