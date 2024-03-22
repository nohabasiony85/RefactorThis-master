using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Api.Controllers.ProductOptions;

public record CreateProductOptionRequest(Guid ProductId, string Name, string Description) : ICommand<Guid>;