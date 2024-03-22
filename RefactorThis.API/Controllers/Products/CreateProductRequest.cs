using RefactorThis.Application.Abstractions;

namespace RefactorThis.Api.Controllers.Products;

public record CreateProductRequest(string Name, string Description ,decimal Price , decimal DeliveryPrice) : ICommand<Guid>;