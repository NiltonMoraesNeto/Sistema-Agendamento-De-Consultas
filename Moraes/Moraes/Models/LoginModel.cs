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
    public class LoginModel
    {
        public string IdUsuario { get; set; }
        public string IdPerfil { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o E-mail do Usuário!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O E-mail informado é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a Senha do Usuário!")]
        public string Senha { get; set; }

        public int IdLicenca { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"SELECT IdUsuario, IdPerfil, Nome, IdLicenca FROM usuario WHERE email=@email AND senha=@senha";
            MySqlCommand Command = new MySqlCommand();
            DAL objDAL = new DAL();
            Command.CommandText = sql;
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@senha", Senha);

            DataTable dt = objDAL.RetDataTable(Command);

            if (dt.Rows.Count == 1)
            {
                IdUsuario = dt.Rows[0]["IdUsuario"].ToString();
                Nome = dt.Rows[0]["Nome"].ToString();
                IdLicenca = Convert.ToInt32(dt.Rows[0]["IdLicenca"].ToString());
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
