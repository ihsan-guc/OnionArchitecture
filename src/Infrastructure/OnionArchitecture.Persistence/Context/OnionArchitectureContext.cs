using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Persistence.Context
{
    public class OnionArchitectureContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public OnionArchitectureContext(DbContextOptions<OnionArchitectureContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OnionArchitectureContext).Assembly);
        }
    }
}
