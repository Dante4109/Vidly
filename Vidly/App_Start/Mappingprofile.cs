using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class Mappingprofile : Profile
    {
        public Mappingprofile()
        {

            //Domain to Dto
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MembershipType, MembershipTypeDto>();
            CreateMap<Genre, GenreDto>();


            // Dto to Domain
            CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, Opt => Opt.Ignore());

            CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, Opt => Opt.Ignore());

        }
    }
}