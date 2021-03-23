using ProjetoMVCEntityFW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoMVCEntityFW.Dal
{
    public class DogInitializer : DropCreateDatabaseIfModelChanges<DogContext>
    {
        protected override void Seed(DogContext context)
        {
            var dogs = new List<Dog>
            {
                new Dog{Id = 1, Nome = "Gaby", Raca = "Puddle"},
                new Dog{Id = 2, Nome = "Arroz", Raca = "Golden"},
            };
            dogs.ForEach(d => context.Dogs.Add(d));
            context.SaveChanges();
        }
    }
}