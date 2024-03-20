using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.ProductOptions.CreateProductOptionCommand;

public record CreateProductOptionCommand() : ICommand<Guid>;