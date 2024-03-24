using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.Products.DeleteProductCommand;

public record DeleteProductCommand(Guid Id) : ICommand;