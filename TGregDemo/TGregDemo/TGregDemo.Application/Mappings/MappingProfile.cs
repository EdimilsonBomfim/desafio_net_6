using AutoMapper;
using TGregDemo.Application.DTOs;
using TGregDemo.Application.DTOs.Adress;
using TGregDemo.Application.DTOs.Customers;
using TGregDemo.Domain.Entities;

namespace TGregDemo.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CustomerDTO, Customer>().ReverseMap();
            CreateMap<CreateCustomerDTO, Customer>();
            CreateMap<UpdateCustomerDTO, Customer>();

            CreateMap<AdressDTO, Adress>().ReverseMap();
            CreateMap<CreateAdressDTO, Adress>();
        }
    }
}
