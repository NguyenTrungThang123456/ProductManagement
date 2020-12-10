using MediatR;
using ProductManagement.Application.Products.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<ProductVm>
    {
        public int Id { get; set; }
    }
}
