using FluentValidation;
using ProductManagement.Application.Products.Commands;

namespace ProductManagement.Application.Products.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(v => v.Name).NotNull();
            RuleFor(v => v.Status).NotNull();
        }
    }
}
