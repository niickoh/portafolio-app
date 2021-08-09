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
    public class Datos_OrdenDeCompra
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();

        public DataTable listar()
        {
            string p_ordendecompra_id = "";
            db.ConexionBD().Open();
            OracleCommand listar = new OracleCommand("PKG_ORDENDECOMPRA.PR_LISTAR_O_BUSCAR_ORDENDECOMPRA", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;
            listar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            listar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.VarChar).Value = p_ordendecompra_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable buscar(string p_ordendecompra_id)
        {

            db.ConexionBD().Open();
            OracleCommand buscar = new OracleCommand("PKG_PROVEEDOR.PR_LISTAR_O_BUSCAR_PROVEEDOR", db.ConexionBD());
            buscar.CommandType = System.Data.CommandType.StoredProcedure;
            buscar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            buscar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.VarChar).Value = p_ordendecompra_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = buscar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable agregar(int p_usuarioescritorio_id, int p_proveedor_id, string p_fecha_solicitud, string p_descripcion, int p_total)
        {
            OracleCommand agregar = new OracleCommand("PKG_ORDENDECOMPRA.PR_AGREGAR_ORDENDECOMPRA", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_USUARIOESCRITORIO_ID", OracleType.Number).Value = p_usuarioescritorio_id;
            agregar.Parameters.Add("P_PROVEEDOR_ID", OracleType.Number).Value = p_proveedor_id;
            agregar.Parameters.Add("P_FECHA_SOLICITUD", OracleType.VarChar).Value = p_fecha_solicitud;
            agregar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            agregar.Parameters.Add("P_TOTAL", OracleType.Number).Value = p_total;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable modificar(int p_ordendecompra_id, int p_usuarioescritorio_id, int p_proveedor_id, string p_fecha_solicitud, string p_descripcion, int p_total)
        {
            OracleCommand modificar = new OracleCommand("PKG_ORDENDECOMPRA.PR_ACTUALIZAR_ORDENDECOMPRA", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.Number).Value = p_ordendecompra_id;
            modificar.Parameters.Add("P_USUARIOESCRITORIO_ID", OracleType.Number).Value = p_usuarioescritorio_id;
            modificar.Parameters.Add("P_PROVEEDOR_ID", OracleType.Number).Value = p_proveedor_id;
            modificar.Parameters.Add("P_FECHA_SOLICITUD", OracleType.VarChar).Value = p_fecha_solicitud;
            modificar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            modificar.Parameters.Add("P_TOTAL", OracleType.Number).Value = p_total;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable eliminar(int p_ordendecompra_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_ORDENDECOMPRA.PR_BORRAR_ORDENDECOMPRA", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.Number).Value = p_ordendecompra_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
