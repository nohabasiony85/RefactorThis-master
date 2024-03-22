namespace RefactorThis.Application.Products.DeleteProductCommand;

public record DeleteProductCommand() : Abstractions.ICommand<Guid>;