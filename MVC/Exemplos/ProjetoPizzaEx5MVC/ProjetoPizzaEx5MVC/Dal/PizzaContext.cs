using ProjetoPizzaEx5MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoPizzaEx5MVC.Dal
{
    public class PizzaContext : DbContext
    {
        public PizzaContext() : base("PizzaContext")
        {

        }

        public DbSet<Pizza> pizzas { get; set; }
    }
}