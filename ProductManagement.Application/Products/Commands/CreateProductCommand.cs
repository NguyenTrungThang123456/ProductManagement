using MediatR;
using ProductManagement.Domain.Enums;

namespace ProductManagement.Application.Products.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public ProductStatus Status { get; set; }
    }
}
