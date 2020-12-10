using MediatR;
using ProductManagement.Application.Products.ViewModels;
using System.Collections.Generic;

namespace ProductManagement.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IList<ProductVm>>
    {
    }
}
