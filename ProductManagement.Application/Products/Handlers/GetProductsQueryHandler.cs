using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Application.Common.Interfaces;
using ProductManagement.Application.Products.Queries;
using ProductManagement.Application.Products.ViewModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManagement.Application.Products.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IList<ProductVm>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<ProductVm>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var result = new List<ProductVm>();

            var products = await _context.Products.ToListAsync();

            if (products != null)
            {
                result = _mapper.Map<List<ProductVm>>(products);
            }


            return result;
        }
    }
}
