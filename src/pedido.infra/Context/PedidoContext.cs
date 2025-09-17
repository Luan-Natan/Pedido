using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using pedido.domain.Models;

namespace pedido.infra.Context
{
    public class PedidoContext
    {
        public required IMongoCollection<Usuario> UsuariosCollection { get; set; }

        public PedidoContext(IConfiguration configuration)
        {
            MongoClient client = new MongoClient(configuration.GetSection("MongoDB").GetSection("ConnectionURI").Value);
            IMongoDatabase database = client.GetDatabase(configuration.GetSection("MongoDB").GetSection("DatabaseName").Value);

            ConfigureCollections(database);
        }

        private void ConfigureCollections(IMongoDatabase database)
        {
            UsuariosCollection = database.GetCollection<Usuario>("usuarios");
        }
    }
}