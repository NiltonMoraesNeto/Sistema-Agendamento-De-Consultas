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
    public class CalendarioModel
    {
        public string Id { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string IdUsuario { get; set; }
        public string Color { get; set; }
        public string IdLicenca { get; set; }

        public List<UsuarioModel> RetornarListaUsuario(int idlicenca)
        {
            //return new UsuarioModel().ListagemUsuarios();
            return new UsuarioModel().ListagemUsuariosMedico(idlicenca);
        }

        public List<CalendarioModel> ListarTodosConsultas(int idlicenca)
        {
            List<CalendarioModel> lista = new List<CalendarioModel>();
            CalendarioModel item;
            DAL objDAL = new DAL();
            string sql = "select c1.IdCalendario, c1.Assunto, c1.Start, c1.End, u.Nome as IdUsuario, v3.NomeEmpresa as IdLicenca from calendario c1 " +
                " inner join usuario u on c1.IdUsuario = u.IdUsuario inner join licenca v3 on c1.IdLicenca = v3.IdLicenca " + 
                $"where c1.IdLicenca ='{idlicenca}' order by Assunto";
            //string sql = "SELECT * FROM calendario order by Assunto asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new CalendarioModel
                {
                    Id = dt.Rows[i]["IdCalendario"].ToString(),
                    Assunto = dt.Rows[i]["Assunto"].ToString(),
                    //Descricao = dt.Rows[i]["Descricao"].ToString(),
                    Start = DateTime.Parse(dt.Rows[i]["Start"].ToString()).ToString("dd/MM/yyyy hh:mm:ss"),
                    End = DateTime.Parse(dt.Rows[i]["End"].ToString()).ToString("dd/MM/yyyy hh:mm:ss"),
                    IdUsuario = dt.Rows[i]["IdUsuario"].ToString(),
                    //Color = dt.Rows[i]["Color"].ToString(),
                    IdLicenca = dt.Rows[i]["IdLicenca"].ToString()
                };
                lista.Add(item);
            }

            return lista;
        }

        public List<CalendarioModel> RetornarConsulta(int idlicenca)
        {
            DAL objDAL = new DAL();

            string sql = "select c1.IdCalendario, c1.Assunto, c1.Descricao, c1.Start, c1.End, u.Nome as IdUsuario, u.Color as Color, v3.NomeEmpresa as IdLicenca " +
                " from calendario c1 inner join usuario u on c1.IdUsuario = u.IdUsuario inner join licenca v3 on c1.IdLicenca = v3.IdLicenca " +
                $" where c1.IdLicenca ='{idlicenca}'";
            //string sql = "select * from calendario";
            DataTable dt = objDAL.RetDataTable(sql);

            List<CalendarioModel> lista = new List<CalendarioModel>();
            CalendarioModel item;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new CalendarioModel();
                //item.QtdeVendido = double.Parse(dt.Rows[i]["qtde"].ToString());
                item.Id = dt.Rows[i]["IdCalendario"].ToString();
                item.Assunto = dt.Rows[i]["Assunto"].ToString();
                item.Descricao = dt.Rows[i]["Descricao"].ToString();
                item.Start = DateTime.Parse(dt.Rows[i]["Start"].ToString()).ToString("yyyy-MM-dd hh:mm:ss");
                item.End = DateTime.Parse(dt.Rows[i]["End"].ToString()).ToString("yyyy-MM-dd hh:mm:ss");
                item.IdUsuario = dt.Rows[i]["IdUsuario"].ToString();
                item.Color = dt.Rows[i]["Color"].ToString();
                item.IdLicenca = dt.Rows[i]["IdLicenca"].ToString();

                lista.Add(item);
            }
            return lista;
        }

        public CalendarioModel RetornarCadastroCalendar(int? id)
        {
            CalendarioModel item;
            DAL objDAL = new DAL();
            string sql = $"SELECT * FROM calendario where IdCalendario ='{id}'";
            DataTable dt = objDAL.RetDataTable(sql);

            item = new CalendarioModel
            {
                Id = dt.Rows[0]["IdCalendario"].ToString(),
                Assunto = dt.Rows[0]["Assunto"].ToString(),
                Descricao = dt.Rows[0]["Descricao"].ToString(),
                Start = DateTime.Parse(dt.Rows[0]["Start"].ToString()).ToString("yyyy-MM-dd hh:mm:ss"),
                End = DateTime.Parse(dt.Rows[0]["End"].ToString()).ToString("yyyy-MM-dd hh:mm:ss"),
                IdUsuario = dt.Rows[0]["IdUsuario"].ToString(),
                //Color = dt.Rows[0]["Color"].ToString(),
            };

            return item;
        }

        //INSERIR OU UPDATE
        public void Gravar(int idlicenca)
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

            if (Id != null)
            {
                sql = $"UPDATE calendario SET Assunto='{Assunto}', Descricao='{Descricao}', " +
                    $" Start='{Start}', End='{End}', IdUsuario='{IdUsuario}', IdLicenca='{idlicenca}'" +
                    $" WHERE IdCalendario = '{Id}'";
            }

            else
            {
                sql = $"INSERT INTO calendario (Assunto, Descricao, Start, End, IdUsuario, Color, IdLicenca) " +
                    $"VALUES ('{Assunto}','{Descricao}', '{Start}', '{End}', '{IdUsuario}', '{Color}', '{idlicenca}')";
            }

            objDAL.ExecutarComandoSQL(sql);
        }

        //DELETAR
        public void Excluir(int id)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM calendario WHERE IdCalendario='{id}'";

            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
