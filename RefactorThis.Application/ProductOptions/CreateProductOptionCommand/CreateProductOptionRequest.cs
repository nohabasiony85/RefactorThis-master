using RefactorThis.Application.Abstractions;

namespace RefactorThis.Application.ProductOptions.CreateProductOptionCommand;

public record CreateProductOptionRequest(Guid ProductId, string Name, string Description) : ICommand<Guid>;