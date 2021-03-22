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
        void Insert(Refeicao msg);

        void Remover(string msg);

        List<Refeicao> Localizar(string msg);

        List<Refeicao> Select();
    }
}