using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;

namespace Negocio_Serviexpress
{
    public class Negocio_ReservaHora
    {
        public DataTable listar()
        {
            return new Datos_Serviexpress.Datos_ReservaHora().listar();
        }
    }
}
