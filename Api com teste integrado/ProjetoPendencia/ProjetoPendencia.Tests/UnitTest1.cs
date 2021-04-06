using Microsoft.EntityFrameworkCore;
using ProjetoPendencia.Api.Controllers;
using ProjetoPendencia.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProjetoPendencia.Tests
{
    public class UnitTest1
    {
        private DbContextOptions<PendenciaContext> options;

        private void InitializeDataBase(){
            options = new DbContextOptionsBuilder<PendenciaContext>().UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;

            using (var context = new PendenciaContext(options)){
                context.Pendencia.Add(new Pendencia { Id = 1, Descricao = "Vitor", Data = "14/11/2002"});
                context.Pendencia.Add(new Pendencia { Id = 2, Descricao = "Luiz", Data = "10/01/1999" });
                context.SaveChanges();
            }
        }

        [Fact]
        public void GetAll()
        {
            InitializeDataBase();
            using(var context = new PendenciaContext(options))
            {
                PendenciaController pendenciaController = new PendenciaController(context);
                IEnumerable<Pendencia> pendencias = pendenciaController.GetPendencia().Result.Value;
                Assert.Equal(2, pendencias.Count());
            }
        }

        [Fact]
        public void GetbyId()
        {
            InitializeDataBase();

            using(var context = new PendenciaContext(options))
            {
                int pendenciaId = 2;
                PendenciaController pendenciaController = new PendenciaController(context);
                Pendencia pendencia = pendenciaController.GetPendencia(pendenciaId).Result.Value;
                Assert.Equal(2, pendencia.Id);
            }
        }

        [Fact]

        public void Create()
        {
            InitializeDataBase();

            Pendencia pendencia = new Pendencia()
            {
                Id = 3,
                Descricao = "Marcelo",
                Data = "05/10/2000"
            };

            using(var context = new PendenciaContext(options))
            {
                PendenciaController pendenciaController = new PendenciaController(context);
                Pendencia pendencia1 = pendenciaController.PostPendencia(pendencia).Result.Value;
                Assert.Equal(3, pendencia1.Id);
            }
        }

        [Fact]
        public void Update()
        {
            InitializeDataBase();

            Pendencia pedencia = new Pendencia()
            {
                Id = 2,
                Descricao = "Luiz Atualizado",
                Data = "sla"
            };

            // Use a clean instance of the context to run the test
            using (var context = new PendenciaContext(options))
            {
                PendenciaController pendenciaController = new PendenciaController(context);
                Pendencia cli = pendenciaController.PutPendencia(2, pedencia).Result.Value;
                Assert.Equal(pedencia.Descricao, cli.Descricao);
            }
        }

        [Fact]
        public void Delete()
        {
            InitializeDataBase();

            // Use a clean instance of the context to run the test
            using (var context = new PendenciaContext(options))
            {
                PendenciaController pendenciaController = new PendenciaController(context);
                Pendencia pendencia = pendenciaController.DeletePendencia(2).Result.Value;
                Assert.Null(pendencia);
            }
        }
    }
}
