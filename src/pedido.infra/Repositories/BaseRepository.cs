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

        public async Task<List<T>> GetByIdAsync(string id)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", id);
            return await _collection.Find(filter).ToListAsync();
        }

        public async Task<T> AddAsync(T obj)
        {
            await _collection.InsertOneAsync(obj);
            return obj;
        }

        public async Task<T> UpdateAsync(string id, T newObj)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", id);

            await _collection.ReplaceOneAsync(filter, newObj);
            return newObj;
        }


        public async Task DeleteByIdAsync(string id)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", id);
            await _collection.DeleteOneAsync(filter);
            return;
        }
    }
}
