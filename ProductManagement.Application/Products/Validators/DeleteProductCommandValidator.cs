using FluentValidation;
using ProductManagement.Application.Products.Commands;
using System;
using System.Collections.Generic;
using System.Text;

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
