using FluentValidation;
using RefactorThis.Domain.ProductOptions.CreateProductOptionCommand;

namespace RefactorThis.Domain.Validators.ProductOption;

public class CreateProductOptionCommandValidator :AbstractValidator<CreateProductOptionCommand>
{
    public CreateProductOptionCommandValidator()
    {
        RuleFor(p => p.ProductId).NotNull().NotEmpty().WithMessage("Product id is required");
        RuleFor(p => p.Description).NotNull().NotEmpty().WithMessage("Product description is required");
        RuleFor(p => p.Name).NotNull().NotEmpty().WithMessage("Product name is required");
    }
    
}