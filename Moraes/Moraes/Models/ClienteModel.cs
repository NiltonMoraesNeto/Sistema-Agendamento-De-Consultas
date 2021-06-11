using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moraes.Uteis;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Moraes.Models
{
    public class ClienteModel
    {
        public string IdCliente { get; set; }

        [Required(ErrorMessage = "Informe o NOME do Cliente")]
        public string Nome { get; set; }

        public string DataNascimento { get; set; }
        public string RG { get; set; }

        [Required(ErrorMessage = "Informe o CPF/CNPJ do Cliente")]
        public string CpfCNPJ { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }

        [Required(ErrorMessage = "Informe o EMAIL do Cliente")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O EMAIL informado é inválido!")]
        public string Email { get; set; }

        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string IdLicenca { get; set; }



        public List<ClienteModel> ListarTodosClientes(int idlicenca)
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            ClienteModel item;
            DAL objDAL = new DAL();
            string sql = $"SELECT * FROM Cliente where IdLicenca ='{idlicenca}' order by Nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ClienteModel
                {
                    IdCliente = dt.Rows[i]["IdCliente"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    DataNascimento = dt.Rows[i]["DataNascimento"].ToString(),
                    //DataNascimento = Convert.ToDateTime(dt.Rows[0]["DataNascimento"]),
                    //DataNascimento = DateTime.Parse(dt.Rows[i]["DataNascimento"].ToString()).ToString("yyyy-MM-dd"),
                    RG = dt.Rows[i]["RG"].ToString(),
                    CpfCNPJ = dt.Rows[i]["CpfCNPJ"].ToString(),
                    TelefoneFixo = dt.Rows[i]["TelefoneFixo"].ToString(),
                    TelefoneCelular = dt.Rows[i]["TelefoneCelular"].ToString(),
                    Email = dt.Rows[i]["Email"].ToString(),
                    Cep = dt.Rows[i]["Cep"].ToString(),
                    Rua = dt.Rows[i]["Rua"].ToString(),
                    Estado = dt.Rows[i]["Estado"].ToString(),
                    Cidade = dt.Rows[i]["Cidade"].ToString(),
                    Bairro = dt.Rows[i]["Bairro"].ToString(),
                    Numero = dt.Rows[i]["Numero"].ToString(),
                    Complemento = dt.Rows[i]["Complemento"].ToString(),
                    IdLicenca = dt.Rows[i]["IdLicenca"].ToString()
                };
                lista.Add(item);
            }

            return lista;
        }

        public ClienteModel RetornarCliente(int? IdCliente)
        {
            ClienteModel item;
            DAL objDAL = new DAL();
            string sql = $"SELECT * FROM Cliente where IdCliente ='{IdCliente}' order by Nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            item = new ClienteModel
            {
                IdCliente = dt.Rows[0]["IdCliente"].ToString(),
                Nome = dt.Rows[0]["Nome"].ToString(),
                DataNascimento = dt.Rows[0]["DataNascimento"].ToString(),
                RG = dt.Rows[0]["RG"].ToString(),
                CpfCNPJ = dt.Rows[0]["CpfCNPJ"].ToString(),
                TelefoneFixo = dt.Rows[0]["TelefoneFixo"].ToString(),
                TelefoneCelular = dt.Rows[0]["TelefoneCelular"].ToString(),
                Email = dt.Rows[0]["Email"].ToString(),
                Cep = dt.Rows[0]["Cep"].ToString(),
                Rua = dt.Rows[0]["Rua"].ToString(),
                Estado = dt.Rows[0]["Estado"].ToString(),
                Cidade = dt.Rows[0]["Cidade"].ToString(),
                Bairro = dt.Rows[0]["Bairro"].ToString(),
                Numero = dt.Rows[0]["Numero"].ToString(),
                Complemento = dt.Rows[0]["Complemento"].ToString(),
                IdLicenca = dt.Rows[0]["IdLicenca"].ToString()
            };

            return item;
        }

        //INSERIR OU UPDATE
        public void Gravar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

            if (IdCliente != null)
            {
                sql = $"UPDATE CLIENTE SET NOME='{Nome}', DataNascimento='{DataNascimento}', RG='{RG}', CpfCNPJ='{CpfCNPJ}', TelefoneFixo='{TelefoneFixo}'," + 
                      $" TelefoneCelular='{TelefoneCelular}', Email='{Email}', Cep='{Cep}', Rua='{Rua}', Estado='{Estado}', Cidade='{Cidade}', Bairro='{Bairro}'," +
                      $" Numero='{Numero}', Complemento='{Complemento}', IdLicenca='{IdLicenca}'" +
                      $" WHERE IdCliente = '{IdCliente}'";
            }

            else
            {
                sql = $"INSERT INTO CLIENTE (Nome, DataNascimento, RG, CpfCNPJ, TelefoneFixo, TelefoneCelular, Email, Cep, Rua, Estado, Cidade, Bairro, Numero, Complemento, IdLicenca)" +
                      $" VALUES ('{Nome}', '{DataNascimento}', '{RG}', '{CpfCNPJ}', '{TelefoneFixo}', '{TelefoneCelular}', '{Email}', '{Cep}', '{Rua}', '{Estado}', " + 
                      $" '{Cidade}', '{Bairro}', '{Numero}', '{Complemento}', '{IdLicenca}')";
            }

            objDAL.ExecutarComandoSQL(sql);
        }

        //DELETAR
        public void Excluir(int IdCliente)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE FROM CLIENTE WHERE IdCliente='{IdCliente}'";

            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
