using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Data;
using Model;

namespace API_Exercicio.Controllers
{
    public class PizzaController : ApiController
    {
        // GET: Pizza        
        public IEnumerable<Refeicao> Get()
        {
            return new RefeicaoDB().Select();
        }
        
        // POST api/values
        public void Post([FromBody] Pizza pizza)
        {
            new RefeicaoDB().Insert(pizza);
        }
    }
}