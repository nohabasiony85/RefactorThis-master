using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.ProductOptions.DeleteProductOptionCommand;

public record DeleteProductOptionCommand() : ICommand<Guid>;