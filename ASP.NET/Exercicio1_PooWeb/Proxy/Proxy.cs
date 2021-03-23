using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy : IMonitore
    {
        private PizzaDB _pizzaDB;
        public Proxy(PizzaDB logDB)
        {
            this._pizzaDB = logDB;
        }

        public void Insert(Pizza msg)
        {
            _pizzaDB.InsertPizza(msg);
        }

        public void Remover(string msg)
        {
            _pizzaDB.RemoverPizza(msg);
        }

        public List<Pizza> LocalizarPizza(string msg)
        {            
            return _pizzaDB.LocalizarPizza(msg);
        }

        public List<Pizza> Select()
        {
            return _pizzaDB.SelectPizza();
        }

    }
}