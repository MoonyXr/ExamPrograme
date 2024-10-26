using ExamPrograme.Repositories;

namespace ExamPrograme.Services
{
    public class EntityService<T> : IEntityService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public EntityService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task AddEntityAsync(T entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllEntitiesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetEntityByIdAsync(short id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task DeleteEntityAsync(short id) 
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
            {
                await _repository.DeleteAsync(entity); 
            }
        }
        
    }
}
