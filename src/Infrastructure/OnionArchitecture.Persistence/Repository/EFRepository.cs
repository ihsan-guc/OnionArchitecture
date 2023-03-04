using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Interface;
using OnionArchitecture.Domain.Comman;
using OnionArchitecture.Persistence.Context;

namespace OnionArchitecture.Persistence.Repository
{
    public class EFRepository<TEntity> : IEFRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly OnionArchitectureContext dbContext;
        public EFRepository(OnionArchitectureContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await dbContext.Set<TEntity>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await dbContext.Set<TEntity>().FindAsync(id);
        }
    }
}
