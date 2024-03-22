using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Application.Products.UpdateProductCommand;

public record UpdateProductCommand() : ICommand<Guid>;