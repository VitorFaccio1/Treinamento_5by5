using ProjetoPizzaEx5MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoPizzaEx5MVC.Dal
{
    public class PizzaInitializer : DropCreateDatabaseIfModelChanges<PizzaContext>
    {
        protected override void Seed(PizzaContext context)
        {
            var pizzas = new List<Pizza>
            {
                new Pizza{Id = 1, Nome = "Calabresa", Valor= 29},
                new Pizza{Id = 2, Nome = "Frango com catupiry", Valor= 32},
            };
            pizzas.ForEach(d => context.pizzas.Add(d));
            context.SaveChanges();
        }
    }
}