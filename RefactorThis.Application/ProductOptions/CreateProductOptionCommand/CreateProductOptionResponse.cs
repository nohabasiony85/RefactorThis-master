namespace RefactorThis.Application.ProductOptions.CreateProductOptionCommand;

public record CreateProductOptionResponse(Guid Id,Guid ProductId, string Name, string Description);