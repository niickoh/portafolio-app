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
    public class Datos_Proveedor
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public DataTable listar()
        {
            string p_nombre = "";
            db.ConexionBD().Open();
            OracleCommand listar = new OracleCommand("PKG_PROVEEDOR.PR_LISTAR_O_BUSCAR_PROVEEDOR", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;
            listar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            listar.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = p_nombre;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable buscar(string p_nombre)
        {

            db.ConexionBD().Open();
            OracleCommand buscar = new OracleCommand("PKG_PROVEEDOR.PR_LISTAR_O_BUSCAR_PROVEEDOR", db.ConexionBD());
            buscar.CommandType = System.Data.CommandType.StoredProcedure;
            buscar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            buscar.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = p_nombre;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = buscar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable agregar(int p_tiporubro_id, string p_nombre, int p_telefono, string p_email)
        {
            OracleCommand agregar = new OracleCommand("PKG_PROVEEDOR.PR_AGREGAR_PROVEEDOR", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_TIPORUBRO_ID", OracleType.Number).Value = p_tiporubro_id;
            agregar.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = p_nombre;
            agregar.Parameters.Add("P_TELEFONO", OracleType.Number).Value = p_telefono;
            agregar.Parameters.Add("P_EMAIL", OracleType.VarChar).Value = p_email;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable modificar(int p_proveedor_id, int p_tiporubro_id, string p_nombre, int p_telefono, string p_email)
        {
            OracleCommand modificar = new OracleCommand("PKG_PROVEEDOR.PR_ACTUALIZAR_PROVEEDOR", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_PROVEEDOR_ID", OracleType.Number).Value = p_proveedor_id;
            modificar.Parameters.Add("P_TIPORUBRO_ID", OracleType.Number).Value = p_tiporubro_id;
            modificar.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = p_nombre;
            modificar.Parameters.Add("P_TELEFONO", OracleType.Number).Value = p_telefono;
            modificar.Parameters.Add("P_EMAIL", OracleType.VarChar).Value = p_email;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable eliminar(int p_proveedor_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_PROVEEDOR.PR_BORRAR_PROVEEDOR", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_PROVEEDOR_ID", OracleType.Number).Value = p_proveedor_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
