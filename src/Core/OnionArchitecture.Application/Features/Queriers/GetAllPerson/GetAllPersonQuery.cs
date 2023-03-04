using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Features.Commands.CreatePerson;
using OnionArchitecture.Application.Interface;
using OnionArchitecture.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Queriers.GetAllPerson
{
    public class GetAllPersonQuery : IRequest<ServiceResponse<List<PersonDto>>>
    {
        public class GetAllPersonQueryHandle : IRequestHandler<GetAllPersonQuery, ServiceResponse<List<PersonDto>>>
        {
            private readonly IPersonRepository PersonRepository;
            private readonly IMapper Mapper;
            public GetAllPersonQueryHandle(IPersonRepository personRepository, IMapper mapper)
            {
                this.Mapper = mapper;
                this.PersonRepository = personRepository;
            }
            public async Task<ServiceResponse<List<PersonDto>>> Handle(GetAllPersonQuery request,  CancellationToken cancellationToken)
            {
                var personList = await PersonRepository.GetAllAsync();
                var mappedPerson = Mapper.Map<List<PersonDto>>(personList);
                return new ServiceResponse<List<PersonDto>>(mappedPerson);
            }
        }
    }
}
