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
    public class Datos_DetPedidoProducto
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();

        public DataTable listar()
        {
            string p_ordendecompra_id = "";
            db.ConexionBD().Open();
            OracleCommand listar = new OracleCommand("PKG_DETPEDIDOPRODUCTO.PR_LISTAR_O_BUSCAR_DETPEDIDOPRODUCTO", db.ConexionBD());
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
            OracleCommand buscar = new OracleCommand("PKG_DETPEDIDOPRODUCTO.PR_LISTAR_O_BUSCAR_DETPEDIDOPRODUCTO", db.ConexionBD());
            buscar.CommandType = System.Data.CommandType.StoredProcedure;
            buscar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            buscar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.VarChar).Value = p_ordendecompra_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = buscar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable agregar(int p_cantidad, int p_ordendecompra_id, int p_producto_id)
        {
            OracleCommand agregar = new OracleCommand("PKG_DETPEDIDOPRODUCTO.PR_AGREGAR_DETPEDIDOPRODUCTO", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_CANTIDAD", OracleType.Number).Value = p_cantidad;
            agregar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.VarChar).Value = p_ordendecompra_id;
            agregar.Parameters.Add("P_PRODUCTO_ID", OracleType.Number).Value = p_producto_id;
            

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable modificar(int p_detpedidoproducto_id, int p_cantidad, int p_ordendecompra_id, int p_producto_id)
        {
            OracleCommand modificar = new OracleCommand("PKG_DETPEDIDOPRODUCTO.PR_ACTUALIZAR_DETPEDIDOPRODUCTO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_DETPEDIDOPRODUCTO_ID", OracleType.Number).Value = p_detpedidoproducto_id;
            modificar.Parameters.Add("P_CANTIDAD", OracleType.Number).Value = p_cantidad;
            modificar.Parameters.Add("P_ORDENDECOMPRA_ID", OracleType.VarChar).Value = p_ordendecompra_id;
            modificar.Parameters.Add("P_PRODUCTO_ID", OracleType.Number).Value = p_producto_id;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }



        public DataTable eliminar(int p_detpedidoproducto_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_DETPEDIDOPRODUCTO.PR_BORRAR_DETPEDIDOPRODUCTO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_PROVEEDOR_ID", OracleType.Number).Value = p_detpedidoproducto_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

    }
}
