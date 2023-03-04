using AutoMapper;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Features.Commands.CreatePerson;
using OnionArchitecture.Application.Features.Queries.GetPersonById;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Mapping
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Person, CreatePersonCommand>().ReverseMap();
            CreateMap<Person, GetPersonByIdViewModel>().ReverseMap();
        }
    }
}
