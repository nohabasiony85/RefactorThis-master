using FluentValidation;

namespace RefactorThis.Application.Products.CreateProductCommand;

public class CreateProductCommandValidator :AbstractValidator<Products.CreateProductCommand.CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.Name).NotNull().NotEmpty().WithMessage("Product name is required");
        RuleFor(p => p.Description).NotNull().NotEmpty().WithMessage("Product description is required");
        RuleFor(p => p.Price).NotNull().NotEmpty().WithMessage("Product price is required");
        RuleFor(p => p.DeliveryPrice).NotNull().NotEmpty().WithMessage("Product delivery price is required");
    }
    
}