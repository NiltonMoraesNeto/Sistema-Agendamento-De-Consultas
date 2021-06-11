using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Moraes.Uteis;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;

namespace Moraes.Models
{
    public class LicencaModel
    {
        public string IdLicenca { get; set; }
        public string NomeEmpresa { get; set; }

        public List<LicencaModel> ListarTodasLicencas()
        {
            List<LicencaModel> lista = new List<LicencaModel>();
            LicencaModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT IdLicenca, NomeEmpresa FROM licenca order by NomeEmpresa asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new LicencaModel
                {
                    IdLicenca = dt.Rows[i]["IdLicenca"].ToString(),
                    NomeEmpresa = dt.Rows[i]["NomeEmpresa"].ToString(),
                };
                lista.Add(item);
            }

            return lista;
        }

        public LicencaModel RetornarLicenca(int? IdLicenca)
        {
            LicencaModel item;
            DAL objDAL = new DAL();
            string sql = $"SELECT IdLicenca, NomeEmpresa FROM licenca where IdLicenca ='{IdLicenca}' order by NomeEmpresa asc";
            DataTable dt = objDAL.RetDataTable(sql);

            item = new LicencaModel
            {
                IdLicenca = dt.Rows[0]["IdLicenca"].ToString(),
                NomeEmpresa = dt.Rows[0]["NomeEmpresa"].ToString(),
            };

            return item;
        }

        public void Gravar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

            if (IdLicenca != null)
            {
                sql = $"UPDATE licenca SET NomeEmpresa='{NomeEmpresa}' WHERE IdLicenca = '{IdLicenca}'";
            }

            else
            {
                sql = $"INSERT INTO licenca (NomeEmpresa) VALUES ('{NomeEmpresa}')";
            }

            objDAL.ExecutarComandoSQL(sql);
        }

        public void Excluir(int IdLicenca)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM licenca WHERE IdLicenca='{IdLicenca}'";

            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
