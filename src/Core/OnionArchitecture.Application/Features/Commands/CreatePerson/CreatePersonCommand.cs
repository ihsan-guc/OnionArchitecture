using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Interface;
using OnionArchitecture.Application.Wrappers;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Features.Commands.CreatePerson
{
    public class CreatePersonCommand : IRequest<ServiceResponse<int>>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public class CreatePersonCommandHandle : IRequestHandler<CreatePersonCommand, ServiceResponse<int>>
        {
            public readonly IPersonRepository PersonRepository;
            public readonly IMapper Mapper;
            public CreatePersonCommandHandle(IPersonRepository personRepository, IMapper mapper)
            {
                this.PersonRepository= personRepository;
                this.Mapper= mapper;
            }
            public async Task<ServiceResponse<int>> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
            {
                var person = Mapper.Map<Person>(request);
                var entity = await PersonRepository.AddAsync(person);
                return new ServiceResponse<int>(entity.Id);
            }
        }


    }
}
