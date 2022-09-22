using AutoMapper;
using PycApi.Data;
using PycApi.Dto;
using System.ComponentModel;

namespace PycApi.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();

            CreateMap<CategoryDto, Category>().ReverseMap();

            CreateMap<AccountDto, Account>().ReverseMap();

            CreateMap<AuthDto, Auth>().ReverseMap();

        }

    }
}
