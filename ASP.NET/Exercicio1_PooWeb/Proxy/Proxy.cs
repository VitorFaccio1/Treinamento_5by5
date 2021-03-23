using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Proxy
{
    public class Proxy : IMonitore
    {
        private ConnectionDB conn;

        private PizzaDB _pizzaDB;
        public Proxy(PizzaDB logDB)
        {
            this._pizzaDB = logDB;
        }

        public void Insert(Pizza msg)
        {
            _pizzaDB.InsertPizza(msg);
        }

        public void Remover(int id)
        {
            _pizzaDB.RemoverPizza(id);
        }

        public List<Pizza> LocalizarPizza(int id)
        {            
            return _pizzaDB.LocalizarPizza(id);
        }

        public List<Pizza> Select()
        {
            return _pizzaDB.SelectPizza();
        }

    



    }
}