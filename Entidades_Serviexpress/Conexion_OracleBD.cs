using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;

namespace Entidades_Serviexpress
{
    public class Conexion_OracleBD
    {
        public OracleConnection ConexionBD()
        {
            string xeora = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = xeora;
            return conn;
        }
    }
}
