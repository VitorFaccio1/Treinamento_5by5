using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjProduto.Models
{
    public class Fornecedor
    {
        

        public string Id { get; set; }

        public string Name { get; set; }

        public string Telefone { get; set; }
    }
}