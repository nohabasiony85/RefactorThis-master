using FluentValidation;

namespace RefactorThis.Application.ProductOptions.CreateProductOptionCommand;

public class CreateProductOptionCommandValidator :AbstractValidator<CreateProductOptionCommand>
{
    public CreateProductOptionCommandValidator()
    {
        RuleFor(p => p.ProductId).NotNull().NotEmpty().WithMessage("Product id is required");
        RuleFor(p => p.Description).NotNull().NotEmpty().WithMessage("Product description is required");
        RuleFor(p => p.Name).NotNull().NotEmpty().WithMessage("Product name is required");
    }
    
}