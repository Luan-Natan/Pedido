using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pedido.domain.Models
{
    public class Usuario : BaseModel
    {
        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        public Usuario(string nome, string? email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
