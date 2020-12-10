using MediatR;
using ProductManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Products.Commands
{
    public class DeleteProductCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
