using MediatR;
using ProductManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Products.Commands
{
    public class UpdateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductStatus Status { get; set; }
    }
}
