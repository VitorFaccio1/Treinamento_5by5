using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Classe1
{
    class Pessoa
    {
        #region exemplo geral de atributo
        //private int id;
        public int id;


        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
        #endregion

        #region Exemplo 2 - c#
        private string nome;

        public string Nome
        {
            get
            {
                return this.nome;
            }

            set
            {
                this.nome = value;
            }
        }
        #endregion

        #region Exemplo 3 - propriedade c#
        public int Idade { get; set; }
        #endregion

        public Endereco endereco;

        public override string ToString()
        {
            return ($"Id: {this.id}, Nome: {nome} e idade: {Idade} ");
        }

        #region Metodos costrutores tradicionais
        /* METODOS CONTRUTORES TRADICIONAIS
        public Pessoa()
        {
            id = 0;
            Nome = "zé ninguem";
            Idade = 0;
        }

        public Pessoa(int id, string nome, int idade)
        {
            this.id = id;
            Nome = nome;
            Idade = idade;
        }*/

        #endregion



        public bool Maior()
        {
            if (Idade >= 18)            
                return true;
            return false;
            
        }
    }
}
