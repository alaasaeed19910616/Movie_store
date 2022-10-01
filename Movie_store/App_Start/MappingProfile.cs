using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Movie_store.Dtos;
using Movie_store.Models;

namespace Movie_store.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}