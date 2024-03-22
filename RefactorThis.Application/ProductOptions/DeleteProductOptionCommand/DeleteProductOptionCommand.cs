using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.ProductOptions.DeleteProductOptionCommand;

public record DeleteProductOptionCommand() : ICommand<Guid>;