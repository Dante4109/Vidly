using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.DTOS;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class Mappingprofile : Profile
    {
        public Mappingprofile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}