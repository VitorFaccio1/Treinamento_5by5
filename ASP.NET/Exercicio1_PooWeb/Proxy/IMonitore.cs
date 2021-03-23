using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IMonitore
    {
        void Insert(Pizza msg);

        void Remover(int id);

        List<Pizza> LocalizarPizza(int id);

        List<Pizza> Select();

    }
}