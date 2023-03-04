using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Interface;
using OnionArchitecture.Application.Parameters;
using OnionArchitecture.Application.Wrappers;

namespace OnionArchitecture.Application.Features.Queriers.GetAllPerson
{
    public class GetAllPersonQuery : IRequest<ServiceResponse<List<PersonDto>>>
    {
        public RequestParameter RequestParameter { get; set; }
        //public int PageNumber { get; set; }
        //public int PageSize { get; set; }
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
                personList = personList.Skip(request.RequestParameter.PageSize * request.RequestParameter.PageNumber).Take(request.RequestParameter.PageSize).ToList().ToList();
                var mappedPerson = Mapper.Map<List<PersonDto>>(personList);
                return new ServiceResponse<List<PersonDto>>(mappedPerson);
            }
        }
    }
}
