namespace RefactorThis.Domain.Products.CreateProductCommand;

public record CreateProductResponse(Guid Id, string Name, string Description ,decimal Price , decimal DeliveryPrice);