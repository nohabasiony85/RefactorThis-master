namespace RefactorThis.Application.Products.CreateProductCommand;

public record CreateProductResponse(Guid Id, string Name, string Description ,decimal Price , decimal DeliveryPrice);