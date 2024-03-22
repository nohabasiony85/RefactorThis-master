using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.ProductOptions.UpdateProductOptionCommand;

public record UpdateProductOptionCommand() : ICommand<Guid>;