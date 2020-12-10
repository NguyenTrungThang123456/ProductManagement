using MediatR;

namespace ProductManagement.Application.Products.Commands
{
    public class DeleteProductCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
