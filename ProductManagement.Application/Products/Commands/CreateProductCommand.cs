using MediatR;
using ProductManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Products.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public ProductStatus Status { get; set; }
    }
}
