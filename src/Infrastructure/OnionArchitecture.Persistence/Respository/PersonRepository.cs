using OnionArchitecture.Application.Interface;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Persistence.Context;

namespace OnionArchitecture.Persistence.Respository
{
    public class PersonRepository : EFRepository<Person>, IPersonRepository
    {
        public PersonRepository(OnionArchitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
