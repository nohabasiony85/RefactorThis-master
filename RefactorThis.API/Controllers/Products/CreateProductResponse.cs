namespace RefactorThis.Api.Controllers.Products;

public record CreateProductResponse(Guid Id, string Name, string Description ,decimal Price , decimal DeliveryPrice);