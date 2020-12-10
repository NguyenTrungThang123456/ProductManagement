using MediatR;
using ProductManagement.Domain.Enums;

namespace ProductManagement.Application.Products.Commands
{
    public class UpdateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductStatus Status { get; set; }
    }
}
