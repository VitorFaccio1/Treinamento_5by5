using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Data;
using Model;
using Proxy;

namespace API_Exercicio.Controllers
{
    public class PizzaController : ApiController
    {
        // GET: Pizza        
        public IEnumerable<Pizza> Get()
        {
            IMonitore proxy = new Proxy.Proxy(new PizzaDB());
            
            return proxy.Select();
        }

        // POST api/values
        public void Post([FromBody] Pizza pizza)
        {
            IMonitore proxy = new Proxy.Proxy(new PizzaDB());
            proxy.Insert(pizza);
        }
    }
}