using AutoMapper;
using ProductManagement.Application.Products.Commands;
using ProductManagement.Application.Products.ViewModels;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Products.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductVm>();
            CreateMap<ProductVm, Product>();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<DeleteProductCommand, Product>();
        }
    }
}
