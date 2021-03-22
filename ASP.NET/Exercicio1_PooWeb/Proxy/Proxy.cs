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
        private RefeicaoDB _refeicaoDB;
        public Proxy(RefeicaoDB logDB)
        {
            this._refeicaoDB = logDB;
        }

        public void Insert(Refeicao msg)
        {
            _refeicaoDB.Insert(msg);
        }

        public void Remover(string msg)
        {
            _refeicaoDB.Remover(msg);
        }

        public List<Refeicao> Localizar(string msg)
        {            
            return _refeicaoDB.Localizar(msg);
        }

        public List<Refeicao> Select()
        {
            return _refeicaoDB.Select();
        }
    }
}