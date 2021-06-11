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
    public class PerfilModel
    {
        public string Id { get; set; }
        public string NomePerfil { get; set; }

        public List<PerfilModel> ListarTodosPerfils()
        {
            List<PerfilModel> lista = new List<PerfilModel>();
            PerfilModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT IdPerfil, NomePerfil FROM perfil order by NomePerfil asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new PerfilModel
                {
                    Id = dt.Rows[i]["IdPerfil"].ToString(),
                    NomePerfil = dt.Rows[i]["NomePerfil"].ToString(),
                };
                lista.Add(item);
            }

            return lista;
        }

        public PerfilModel RetornarPerfil(int? id)
        {
            PerfilModel item;
            DAL objDAL = new DAL();
            string sql = $"SELECT IdPerfil, NomePerfil FROM perfil where IdPerfil ='{id}' order by NomePerfil asc";
            DataTable dt = objDAL.RetDataTable(sql);

            item = new PerfilModel
            {
                Id = dt.Rows[0]["IdPerfil"].ToString(),
                NomePerfil = dt.Rows[0]["NomePerfil"].ToString(),
            };

            return item;
        }

        public void Gravar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

            if (Id != null)
            {
                sql = $"UPDATE perfil SET NomePerfil='{NomePerfil}' WHERE IdPerfil = '{Id}'";
            }

            else
            {
                sql = $"INSERT INTO perfil (NomePerfil) VALUES ('{NomePerfil}')";
            }

            objDAL.ExecutarComandoSQL(sql);
        }

        public void Excluir(int id)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM perfil WHERE IdPerfil='{id}'";

            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
