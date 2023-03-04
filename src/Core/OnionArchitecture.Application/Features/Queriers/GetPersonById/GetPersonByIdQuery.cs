using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Interface;
using OnionArchitecture.Application.Wrappers;

namespace OnionArchitecture.Application.Features.Queries.GetPersonById
{
    public class GetPersonByIdQuery : IRequest<ServiceResponse<GetPersonByIdViewModel>>
    {
        public int Id { get; set; }
        public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, ServiceResponse<GetPersonByIdViewModel>>
        {
            private readonly IPersonRepository PersonRepository;
            private readonly IMapper Mapper;
            public GetPersonByIdQueryHandler(IPersonRepository personRepository, IMapper mapper)
            {
                PersonRepository = personRepository;
                Mapper = mapper;
            }
            public async Task<ServiceResponse<GetPersonByIdViewModel>> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
            {
                var person = await PersonRepository.GetByIdAsync(request.Id);
                var mappedPerson = Mapper.Map<GetPersonByIdViewModel>(person);
                return new ServiceResponse<GetPersonByIdViewModel>(mappedPerson);
            }
        }
    }
}
