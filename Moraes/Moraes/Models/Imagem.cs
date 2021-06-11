using Moraes.Uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moraes.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Dados { get; set; }
        public string ContentType { get; set; }

        public void Gravar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

                sql = "INSERT INTO imagens(Nome, Dados, ContentType) " +
                    $" VALUES({Nome}, '{Dados}', '{ContentType}')";

            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
