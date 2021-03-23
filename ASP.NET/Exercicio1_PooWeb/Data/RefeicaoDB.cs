using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
using Model;
using System.Data.SqlClient;
using System.Globalization;

namespace Data
{
    public class RefeicaoDB
    {
        private ConnectionDB conn;
        public void Insert(Refeicao refeicao)
        {
            string sql = string.Format("insert into Refeicao(Descricao, Valor) values ('{0}',{1})", refeicao.Descricao, refeicao.Valor);

            using (conn = new ConnectionDB())
            {
                conn.ExecQuery(sql);
            }
        }

        public List<Refeicao> Select()
        {
            using (conn = new ConnectionDB())
            {
                string sql = "select Id,Descricao,Valor from Refeicao";

                var returnData = conn.ExecQueryReturn(sql);

                return TransformSQLReaderToList(returnData);
            }
        }

        private List<Refeicao> TransformSQLReaderToList(SqlDataReader ReturnData)
        {
            var list = new List<Refeicao>();

            while (ReturnData.Read())
            {
                var item = new Refeicao()
                {
                    Id = int.Parse(ReturnData["Id"].ToString()),
                    Descricao = ReturnData["Descricao"].ToString(),
                    Valor = double.Parse(ReturnData["Valor"].ToString())
                };

                list.Add(item);
            }

            return list;
        }

        public List<Refeicao> Localizar(string Refeicao)
        {
            using (conn = new ConnectionDB())
            {
                string sql = $"select Id,Descricao,Valor from Refeicao where Id = '{Refeicao}'";

                var returnData = conn.ExecQueryReturn(sql);

                return TransformSQLReaderToList(returnData);
            }
        }

        public void Remover(string Refeicao)
        {
            using (conn = new ConnectionDB())
            {
                string sql = $"delete from Refeicao where Id = '{Refeicao}'";

                conn.ExecQuery(sql);

            }
        }
    }
}
