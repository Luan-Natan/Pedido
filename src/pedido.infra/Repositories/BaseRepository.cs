using MongoDB.Bson;
using MongoDB.Driver;
using pedido.domain.Interfaces.Repositories;

namespace pedido.infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly IMongoCollection<T> _collection;
        public BaseRepository(IMongoCollection<T> collection)
        {
            _collection = collection;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }
    }
}