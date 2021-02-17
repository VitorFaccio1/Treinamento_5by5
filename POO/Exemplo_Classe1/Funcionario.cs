using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Classe1
{
    class Funcionario : Pessoa
    {
        #region Propriedades
        public int QtadFilhos { get; set; }
        public string Id { get; set; }
        #endregion

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
