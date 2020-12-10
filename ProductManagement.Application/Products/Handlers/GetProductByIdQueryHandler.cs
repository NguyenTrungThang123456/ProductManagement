using AutoMapper;
using MediatR;
using ProductManagement.Application.Common.Interfaces;
using ProductManagement.Application.Products.Queries;
using ProductManagement.Application.Products.ViewModels;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManagement.Application.Products.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetProductByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<ProductVm> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = new ProductVm();

            var product = await _context.Products.FindAsync(request.Id);

            if (product != null)
            {
                result = _mapper.Map<ProductVm>(product);
            }

            return result;
        }
    }
}
