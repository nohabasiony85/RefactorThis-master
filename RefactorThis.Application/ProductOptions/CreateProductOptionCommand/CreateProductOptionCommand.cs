using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.ProductOptions.CreateProductOptionCommand;

public record CreateProductOptionCommand(Guid ProductId, string Name, string Description) : ICommand;