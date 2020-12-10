using FluentValidation;
using ProductManagement.Application.Products.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Products.Validators
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {

            RuleFor(v => v.Name).NotNull();
            RuleFor(v => v.Status).NotNull();
        }
    }
}
