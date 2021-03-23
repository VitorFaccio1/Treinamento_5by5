using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Data
{
    public class PizzaDB
    {
        private ConnectionDB conn;
        public void InsertPizza(Pizza _pizza)
        {
            string sql = string.Format("insert into Pizza(Descricao, Valor) values ('{0}',{1})", _pizza.Descricao, _pizza.Valor);

            using (conn = new ConnectionDB())
            {
                conn.ExecQuery(sql);
            }
        }

        public List<Pizza> SelectPizza()
        {
            using (conn = new ConnectionDB())
            {
                string sql = "select Id_pizza,Descricao,Valor from Pizza";

                var returnData = conn.ExecQueryReturn(sql);

                return TransformSQLReaderToListPizza(returnData);
            }
        }

        private List<Pizza> TransformSQLReaderToListPizza(SqlDataReader ReturnData)
        {
            var list = new List<Pizza>();

            while (ReturnData.Read())
            {
                var item = new Pizza()
                {
                    Id = int.Parse(ReturnData["Id_pizza"].ToString()),
                    Descricao = ReturnData["Descricao"].ToString(),
                    Valor = double.Parse(ReturnData["Valor"].ToString())
                };

                list.Add(item);
            }

            return list;
        }

        public List<Pizza> LocalizarPizza(string _pizza)
        {
            using (conn = new ConnectionDB())
            {
                string sql = $"select Id_pizza,Descricao,Valor from Pizza where Id = '{_pizza}'";

                var returnData = conn.ExecQueryReturn(sql);

                return TransformSQLReaderToListPizza(returnData);
            }
        }

        public void RemoverPizza(string _pizza)
        {
            using (conn = new ConnectionDB())
            {
                string sql = $"delete from Pizza where Id_pizza = '{_pizza}'";

                conn.ExecQuery(sql);

            }
        }
    }
}
