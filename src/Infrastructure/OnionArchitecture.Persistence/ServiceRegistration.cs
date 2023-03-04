using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interface;
using OnionArchitecture.Persistence.Context;
using OnionArchitecture.Persistence.Repository;

namespace OnionArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<OnionArchitectureContext>(options => options.UseInMemoryDatabase("memoryDb"));
            services.AddScoped(typeof(IEFRepository<>), typeof(EFRepository<>));
            services.AddScoped<IPersonRepository, PersonRepository>();
        }
    }
}
