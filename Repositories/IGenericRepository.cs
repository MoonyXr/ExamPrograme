namespace ExamPrograme.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(short id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T id);
    }
}
