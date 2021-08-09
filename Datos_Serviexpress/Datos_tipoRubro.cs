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
    public class Datos_tipoRubro
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public DataTable listar()
        {
            string p_tiporubro_id = "";
            db.ConexionBD().Open();
            OracleCommand comando = new OracleCommand("PKG_TIPORUBRO.PR_LISTAR_O_BUSCAR_TIPORUBRO", db.ConexionBD());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("P_TIPORUBRO_ID", OracleType.VarChar).Value = p_tiporubro_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }

        public DataTable buscar(string p_tiporubro_id)
        {
            
            db.ConexionBD().Open();
            OracleCommand comando = new OracleCommand("PKG_TIPORUBRO.PR_LISTAR_O_BUSCAR_TIPORUBRO", db.ConexionBD());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("P_TIPORUBRO_ID", OracleType.VarChar).Value = p_tiporubro_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable agregar(string descripcion)
        {
            OracleCommand agregar = new OracleCommand("PKG_TIPORUBRO.PR_AGREGAR_TIPORUBRO", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = descripcion;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataTable modificar(int p_tiporubro_id, string p_descripcion)
        {
            OracleCommand modificar = new OracleCommand("PKG_TIPORUBRO.PR_ACTUALIZAR_TIPORUBRO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_TIPORUBRO_ID", OracleType.Number).Value = p_tiporubro_id;
            modificar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable eliminar(int p_tiporubro_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_TIPORUBRO.PR_BORRAR_TIPORUBRO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_TIPORUBRO_ID", OracleType.Number).Value = p_tiporubro_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
