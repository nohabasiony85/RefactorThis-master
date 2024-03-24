using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.ProductOptions.DeleteProductOptionCommand;

public record DeleteProductOptionCommand(Guid Id, Guid ProductId) : ICommand<bool>;