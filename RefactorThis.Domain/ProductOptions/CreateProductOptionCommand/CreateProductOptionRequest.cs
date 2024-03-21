using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.ProductOptions.CreateProductOptionCommand;

public record CreateProductOptionRequest(Guid ProductId, string Name, string Description) : ICommand<Guid>;