using FluentValidation;
using ProductManagement.Application.Products.Commands;
using System;
using System.Collections.Generic;
using System.Text;

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
