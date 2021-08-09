using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;

namespace Datos_Serviexpress
{
    public class Datos_ReservaHora
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public DataTable listar()
        {
            string p_usuarioweb_id = "";
            OracleCommand listar = new OracleCommand("PKG_RESERVADEHORA.PR_LISTAR_O_BUSCAR_RESERVADEHORA", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;
            listar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            listar.Parameters.Add("P_USUARIOWEB_ID", OracleType.VarChar).Value = p_usuarioweb_id;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;
        }
    }
}
