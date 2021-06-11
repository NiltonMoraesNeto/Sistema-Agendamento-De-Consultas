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
    public class UsuarioModel
    {
        public string IdUsuario { get; set; }
        public string IdPerfil { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public string Color { get; set; }
        public string IdLicenca { get; set; }
        public string Foto { get; set; }

        public List<PerfilModel> RetornarListaPerfil()
        {
            return new PerfilModel().ListarTodosPerfils();
        }

        public List<LicencaModel> RetornarListaLicenca()
        {
            return new LicencaModel().ListarTodasLicencas();
        }

        public List<UsuarioModel> ListagemUsuarios(int idlicenca)
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            UsuarioModel item;
            DAL objDAL = new DAL();
            //string sql = "SELECT IdUsuario, IdPerfil, IdEndereco, Nome, Email, TelefoneFixo, TelefoneCelular, DataNascimento, Crm, " +
            //    "Cpf, Rg, OrgaoEmissor, Senha, IdEstadoCivil, IdSexo FROM usuario order by Nome asc";

            string sql = " select v1.IdUsuario, v1.Nome, v1.Email, v1.Senha, v1.Color, v1.Foto, v2.NomePerfil as Perfil, v3.NomeEmpresa as Licenca from " +
                " usuario v1 inner join perfil v2 on v1.IdPerfil = v2.IdPerfil inner join licenca v3 on v1.IdLicenca = v3.IdLicenca " + 
                $"where v1.IdLicenca ='{idlicenca}' order by Nome";

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new UsuarioModel
                {
                    IdUsuario = dt.Rows[i]["IdUsuario"].ToString(),
                    IdPerfil = dt.Rows[i]["Perfil"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    Email = dt.Rows[i]["Email"].ToString(),
                    Senha = dt.Rows[i]["Senha"].ToString(),
                    Color = dt.Rows[i]["Color"].ToString(),
                    IdLicenca = dt.Rows[i]["Licenca"].ToString(),
                    Foto = dt.Rows[i]["Foto"].ToString()

                };
                lista.Add(item);
            }

            return lista;
        }

        public List<UsuarioModel> ListagemUsuarios2(int id)
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            UsuarioModel item;
            DAL objDAL = new DAL();
            //string sql = "SELECT IdUsuario, IdPerfil, IdEndereco, Nome, Email, TelefoneFixo, TelefoneCelular, DataNascimento, Crm, " +
            //    "Cpf, Rg, OrgaoEmissor, Senha, IdEstadoCivil, IdSexo FROM usuario order by Nome asc";

            string sql = " select v1.IdUsuario, v1.Nome, v1.Email, v1.Senha, v1.Color, v1.Foto, v2.NomePerfil as Perfil, v3.NomeEmpresa as Licenca from " +
                " usuario v1 inner join perfil v2 on v1.IdPerfil = v2.IdPerfil inner join licenca v3 on v1.IdLicenca = v3.IdLicenca " +
                $"where v1.IdUsuario ='{id}' order by Nome";

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new UsuarioModel
                {
                    IdUsuario = dt.Rows[i]["IdUsuario"].ToString(),
                    IdPerfil = dt.Rows[i]["Perfil"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    Email = dt.Rows[i]["Email"].ToString(),
                    Senha = dt.Rows[i]["Senha"].ToString(),
                    Color = dt.Rows[i]["Color"].ToString(),
                    IdLicenca = dt.Rows[i]["Licenca"].ToString(),
                    Foto = dt.Rows[i]["Foto"].ToString()

                };
                lista.Add(item);
            }

            return lista;
        }

        public List<UsuarioModel> ListagemUsuariosMedico(int idlicenca)
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            UsuarioModel item;
            DAL objDAL = new DAL();
            //string sql = "SELECT IdUsuario, IdPerfil, IdEndereco, Nome, Email, TelefoneFixo, TelefoneCelular, DataNascimento, Crm, " +
            //    "Cpf, Rg, OrgaoEmissor, Senha, IdEstadoCivil, IdSexo FROM usuario order by Nome asc";

            //string sql = " select * from usuario " +
            //" where IdPerfil = 7 order by Nome";

            string sql = " select v1.IdUsuario, v1.Nome, v2.NomePerfil as Perfil, v3.NomeEmpresa as IdLicenca " +
                "  from usuario v1 " +
                " inner join perfil v2 on v1.IdPerfil = v2.IdPerfil inner join licenca v3 on v1.IdLicenca = v3.IdLicenca " + 
                $" where v1.IdPerfil = 7 and v1.IdLicenca = '{idlicenca}' order by Nome asc";

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new UsuarioModel
                {
                    IdUsuario = dt.Rows[i]["IdUsuario"].ToString(),
                    IdPerfil = dt.Rows[i]["Perfil"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    IdLicenca = dt.Rows[i]["IdLicenca"].ToString(),

                };
                lista.Add(item);
            }

            return lista;
        }

        public UsuarioModel RetornarUsuario(int? id)
        {
            UsuarioModel item;
            DAL objDAL = new DAL();
            string sql = $"SELECT * FROM usuario where IdUsuario ='{id}' order by Nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            item = new UsuarioModel
            {
                IdUsuario = dt.Rows[0]["IdUsuario"].ToString(),
                IdPerfil = dt.Rows[0]["IdPerfil"].ToString(),
                Nome = dt.Rows[0]["Nome"].ToString(),
                Email = dt.Rows[0]["Email"].ToString(),
                Senha = dt.Rows[0]["Senha"].ToString(),
                Color = dt.Rows[0]["Color"].ToString(),
                IdLicenca = dt.Rows[0]["IdLicenca"].ToString(),
                Foto = dt.Rows[0]["Foto"].ToString()
            };

            return item;
        }

        public void Gravar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;
            //string dataNascimento = DateTime.Now.Date.ToString("yyyy/MM/dd");

            if (IdUsuario != null)
            {
                sql = $"UPDATE usuario SET IdPerfil='{IdPerfil}', Nome='{Nome}', Email='{Email}', Senha='{Senha}', Color='{Color}', IdLicenca='{IdLicenca}', Foto='{Foto}' WHERE IdUsuario = '{IdUsuario}'";
            }

            else
            {
                sql = "INSERT INTO usuario(IdPerfil, Nome, Email, Senha, Color, IdLicenca, Foto) " +
                    $" VALUES({IdPerfil}, '{Nome}', '{Email}', '{Senha}', '{Color}', '{IdLicenca}', '{Foto}')";
            }

            objDAL.ExecutarComandoSQL(sql);
        }

        //DELETAR
        public void Excluir(int IdUsuario)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM usuario WHERE IdUsuario='{IdUsuario}'";

            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
