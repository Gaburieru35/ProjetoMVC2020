using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetoMVCD09.DAL
{
    public class DALMVC
    {
        private MySqlConnection conexao;

        public void ConectarBD()
        {
            conexao = new MySqlConnection("persist security info = false;server=localhost;database=ProjetoMVCD09;user=root;pwd=Mar250970;");
            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Problemas ao Conectar o Banco de Dados");
            }            
        }

        public void AlterarTabelas(string sql)
        {
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ConsultarTabelas(string sql)
        {
            ConectarBD();
            try
            {
                DataTable result = new DataTable();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                consulta.Fill(result);
                return result;
            }
            catch
            {
                throw new Exception("Erro ao carregar registros");
            }
            finally
            {
                conexao.Close();
            }
            
        }
    }
}