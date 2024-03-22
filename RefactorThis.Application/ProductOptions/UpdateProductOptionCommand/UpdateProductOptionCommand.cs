using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Application.ProductOptions.UpdateProductOptionCommand;

public record UpdateProductOptionCommand() : ICommand<Guid>;