using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pedido.domain.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required string Id { get; set; }

        [BsonElement("nome")]
        public required string Nome { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }
    }
}