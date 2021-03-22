using Data;
using Model;
using Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio1_PooWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTable();   
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var pizza = new Pizza();         

            var escolha = txtPizza.Text;

            switch (escolha)
            {
                case "1":
                    pizza = new Pizza { Descricao = "Quatro Queijos", Valor = 48 };    
                    break;
                case "2":
                    pizza = new Pizza { Descricao = "Salame", Valor = 50 };
                    break;
                case "3":
                    pizza = new Pizza { Descricao = "Frango com catupiry", Valor = 47 };
                    break;
                case "4":
                    pizza = new Pizza { Descricao = "Pepperoni", Valor = 46 };
                    break;
                case "5":
                    pizza = new Pizza { Descricao = "Brasileira", Valor = 45 };
                    break;
                case "6":
                    pizza = new Pizza { Descricao = "Portuguesa", Valor = 44 };
                    break;
                case "7":
                    pizza = new Pizza { Descricao = "Parma", Valor = 43 };
                    break;
                case "8":
                    pizza = new Pizza { Descricao = "Brocolis", Valor = 42 };
                    break;
                case "9":
                    pizza = new Pizza { Descricao = "Confete", Valor = 40 };
                    break;
                default:
                    LblRegistro.Text = "Insira um numero correto para pedido";
                    break;
            }

            if (LblRegistro.Text == "" || LblRegistro.Text == "Pedido feito com sucesso!!!")
            {
                LblRegistro.Text = "Pedido feito com sucesso!!!";
            }

            Inserir(pizza);
            LoadTable();
        }

        private void Inserir(Refeicao pizza)
        {
            IMonitore proxy = new Proxy.Proxy(new RefeicaoDB());
            proxy.Insert(pizza);
        }
        private void Remover(string pizza)
        {
            IMonitore proxy = new Proxy.Proxy(new RefeicaoDB());
            proxy.Remover(pizza);
            GVProcura.DataSource = null;
            GVProcura.DataBind();
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            var texto = txtPizza.Text;

            Remover(texto);
            LoadTable();
        }
        

        private List<Refeicao> Localizar(string msg)
        {
            IMonitore proxy = new Proxy.Proxy(new RefeicaoDB());
            return proxy.Localizar(msg);
        }        

        protected void Button1_Click(object sender, EventArgs e)
        {
            var texto = txtPizza.Text;

            GVProcura.DataSource = Localizar(texto);
            GVProcura.DataBind();       
            
        }

        private List<Refeicao> Select()
        {
            IMonitore proxy = new Proxy.Proxy(new RefeicaoDB());
            return proxy.Select();
        }

        private void LoadTable()
        {
            GVPizza.DataSource = Select();
            GVPizza.DataBind();
        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }

        protected void GVProcura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtPizza_TextChanged2(object sender, EventArgs e)
        {

        }

        protected void GVPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}