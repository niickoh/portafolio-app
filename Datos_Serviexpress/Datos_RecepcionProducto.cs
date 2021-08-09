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
    public class Datos_RecepcionProducto
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();

        public DataTable listar()
        {
            string p_recepcionproducto_id = "";
            db.ConexionBD().Open();
            OracleCommand listar = new OracleCommand("PKG_RECEPCIONPRODUCTO.PR_LISTAR_O_BUSCAR_RECEPCIONPRODUCTO", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;
            listar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            listar.Parameters.Add("P_RECEPCIONPRODUCTO_ID", OracleType.VarChar).Value = p_recepcionproducto_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable buscar(string p_recepcionproducto_id)
        {

            db.ConexionBD().Open();
            OracleCommand buscar = new OracleCommand("PKG_RECEPCIONPRODUCTO.PR_LISTAR_O_BUSCAR_RECEPCIONPRODUCTO", db.ConexionBD());
            buscar.CommandType = System.Data.CommandType.StoredProcedure;
            buscar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            buscar.Parameters.Add("P_RECEPCIONPRODUCTO_ID", OracleType.VarChar).Value = p_recepcionproducto_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = buscar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable agregar(string p_fecha, int p_validador, string p_descripcion, int p_ordendecompra_id)
        {
            OracleCommand agregar = new OracleCommand("PKG_RECEPCIONPRODUCTO.PR_AGREGAR_RECEPCIONPRODUCTO", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_FECHA", OracleType.VarChar).Value = p_fecha;
            agregar.Parameters.Add("P_VALIDADOR", OracleType.Number).Value = p_validador;
            agregar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            agregar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.Number).Value = p_ordendecompra_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable modificar(int p_recepcionproducto_id, string p_fecha, int p_validador, string p_descripcion, int p_ordendecompra_id)
        {
            OracleCommand modificar = new OracleCommand("PKG_RECEPCIONPRODUCTO.PR_ACTUALIZAR_RECEPCIONPRODUCTO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_RECEPCIONPRODUCTO_ID", OracleType.Number).Value = p_recepcionproducto_id;
            modificar.Parameters.Add("P_FECHA", OracleType.VarChar).Value = p_fecha;
            modificar.Parameters.Add("P_VALIDADOR", OracleType.Number).Value = p_validador;
            modificar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            modificar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.Number).Value = p_ordendecompra_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable eliminar(int p_recepcionproducto_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_RECEPCIONPRODUCTO.PR_BORRAR_RECEPCIONPRODUCTO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_RECEPCIONPRODUCTO_ID", OracleType.Number).Value = p_recepcionproducto_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
