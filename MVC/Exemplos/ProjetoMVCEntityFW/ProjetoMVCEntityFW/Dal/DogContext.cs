using ProjetoMVCEntityFW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoMVCEntityFW.Dal
{
    public class DogContext : DbContext
    {
        public DogContext() : base("DogContext")
        {

        }

        public DbSet<Dog> Dogs { set; get; }

    }
}