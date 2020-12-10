using AutoMapper;
using MediatR;
using ProductManagement.Application.Common.Interfaces;
using ProductManagement.Application.Products.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManagement.Application.Products.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var result = _context.Products.Remove(await _context.Products.FindAsync(request.Id));
            await _context.SaveChangesAsync(cancellationToken);
            return request.Id;
        }
    }
}
