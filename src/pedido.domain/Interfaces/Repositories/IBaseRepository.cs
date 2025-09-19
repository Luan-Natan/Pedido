namespace pedido.domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();

        Task<List<T>> GetByIdAsync(string id);

        Task<T> AddAsync(T obj);

        Task<T> UpdateAsync(string id, T newObj);

        Task DeleteByIdAsync(string id);
    }
}
