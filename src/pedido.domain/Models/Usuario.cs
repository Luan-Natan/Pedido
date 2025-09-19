using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pedido.domain.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        public Usuario(string? id, string nome, string? email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public Usuario(string nome, string? email)
        {
            Id = string.Empty;
            Nome = nome;
            Email = email;
        }
    }
}
