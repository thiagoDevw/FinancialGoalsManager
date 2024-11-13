namespace FinancialGoalsManager.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
