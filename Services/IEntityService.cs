namespace ExamPrograme.Services
{
    public interface IEntityService<T> where T : class
    {
        Task AddEntityAsync(T entity);
        Task<IEnumerable<T>> GetAllEntitiesAsync();
        Task<T> GetEntityByIdAsync(short id);
        Task DeleteEntityAsync(short id);
    }
}
