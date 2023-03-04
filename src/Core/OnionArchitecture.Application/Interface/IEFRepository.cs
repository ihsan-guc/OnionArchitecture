using OnionArchitecture.Domain.Comman;

namespace OnionArchitecture.Application.Interface
{
    public interface IEFRepository <TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> AddAsync(TEntity entity);
    }
}
