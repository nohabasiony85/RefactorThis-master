using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.ProductOptions.UpdateProductOptionCommand;

public record UpdateProductOptionCommand() : ICommand<Guid>;