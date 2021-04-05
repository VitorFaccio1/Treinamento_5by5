using System.Collections.Generic;
using MongoDB.Driver;
using ProjProduto.Models;
using ProjProduto.Utils;

namespace ProjProduto.Service
{
    public class ProdutoService
    {
        private readonly IMongoCollection<Produto> _clientes;

        public ProdutoService(IProjMongoDotnetDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _clientes = database.GetCollection<Produto>(settings.ClienteCollectionName);
        }

        public List<Produto> Get() =>
            _clientes.Find(cliente => true).ToList();

        public Produto Get(string id) =>
            _clientes.Find<Produto>(produto => produto.Id == id).FirstOrDefault();

        public Produto Create(Produto produto)
        {
            _clientes.InsertOne(produto);
            return produto;
        }

        public void Update(string id, Produto produto) =>
            _clientes.ReplaceOne(produto => produto.Id == id, produto);

        public void Remove(Produto produto) =>
            _clientes.DeleteOne(produto => produto.Id == produto.Id);

        public void Remove(string id) => 
            _clientes.DeleteOne(produto => produto.Id == id);   
    }
}