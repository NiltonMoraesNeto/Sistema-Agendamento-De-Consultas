using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moraes.Models
{
    [Serializable]
    public class Usuarioslicencas
    {
        private LicencaModel _licencas;

        public LicencaModel Licencas
        {
            get { return _licencas; }
            set { _licencas = value; }
        }
    }
}
