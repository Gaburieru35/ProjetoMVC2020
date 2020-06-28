using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crypto.Digests;
using ProjetoMVCD09.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoMVCD09.BLL
{
    public class BLLMVC
    {
        private DALMVC dalmvc = new DALMVC();

        public Boolean consultabeneficio(string cpf, string nome, string nome_mae)
        {
            DataTable dt = dalmvc.ConsultarTabelas(string.Format($@"select * from tbl_clienteD09 where cpf_cliente = '{cpf}' and nome_cliente = '{nome}' and nome_mae = '{nome_mae}'"));
            return dt.Rows.Count > 0?true:false;
        }
    }
}