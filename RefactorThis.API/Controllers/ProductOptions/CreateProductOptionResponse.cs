namespace RefactorThis.Api.Controllers.ProductOptions;

public record CreateProductOptionResponse(Guid Id,Guid ProductId, string Name, string Description);