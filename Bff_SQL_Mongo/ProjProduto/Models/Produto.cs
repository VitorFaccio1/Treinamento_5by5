using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjProduto.Models
{
    public class Produto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}