using FluentValidation;
using ProductManagement.Application.Products.Commands;

namespace ProductManagement.Application.Products.Validators
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(v => v.Id).NotNull();
            RuleFor(v => v.Name).NotNull();
            RuleFor(v => v.Status).NotNull();
        }
    }
}
