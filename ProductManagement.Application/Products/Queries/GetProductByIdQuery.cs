using MediatR;
using ProductManagement.Application.Products.ViewModels;

namespace ProductManagement.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<ProductVm>
    {
        public int Id { get; set; }
    }
}
