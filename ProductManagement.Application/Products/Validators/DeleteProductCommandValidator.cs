using FluentValidation;
using ProductManagement.Application.Products.Commands;

namespace ProductManagement.Application.Products.Validators
{
    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(v => v.Id).NotNull();
        }
    }
}
