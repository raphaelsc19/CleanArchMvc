using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.Products.Queries;
using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();

            // CQRS - Implementação
            // Category
            //CreateMap<CategoryDTO, CategoryCreateCommand>();
            //CreateMap<CategoryDTO, CategoryUpdateCommand>();
            //CreateMap<CategoryDTO, GetCategoriesQuery>();

            // Product
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
            CreateMap<ProductDTO, GetProductsQuery>();
        }
    }
}
