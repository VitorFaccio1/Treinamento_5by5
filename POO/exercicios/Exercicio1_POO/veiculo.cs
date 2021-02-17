using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_POO
{
    class veiculo
    {
        
        
        public double renavam { get; set; }
        public string chassis { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int ano { get; set; }


        public override string ToString()
        {
            return ($"\no renavam do carro é {renavam}\no chassis {chassis}\na placa {placa}" +
                $"\na marca {marca}\no modelo {modelo}\na cor {cor}\no ano {ano}");
        }




    }
}
