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
    public class Datos_tipoProducto
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public DataTable listar()
        {
            string p_tipoproducto_id = "";
            db.ConexionBD().Open();
            OracleCommand listar = new OracleCommand("PKG_TIPOPRODUCTO.PR_LISTAR_O_BUSCAR_TIPOPRODUCTO", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;
            listar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            listar.Parameters.Add("P_TIPOPRODUCTO_ID", OracleType.VarChar).Value = p_tipoproducto_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataTable buscar(string p_tipoproducto_id)
        {
            db.ConexionBD().Open();
            OracleCommand buscar = new OracleCommand("PKG_TIPOPRODUCTO.PR_LISTAR_O_BUSCAR_TIPOPRODUCTO", db.ConexionBD());
            buscar.CommandType = System.Data.CommandType.StoredProcedure;
            buscar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            buscar.Parameters.Add("P_TIPOPRODUCTO_ID", OracleType.VarChar).Value = p_tipoproducto_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = buscar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable agregar(string p_descripcion, int p_precio_compra, int p_precio_venta, int p_stock_critico)
        {
            OracleCommand agregar = new OracleCommand("PKG_TIPOPRODUCTO.PR_AGREGAR_TIPOPRODUCTO", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            agregar.Parameters.Add("P_PRECIO_COMPRA", OracleType.Number).Value = p_precio_compra;
            agregar.Parameters.Add("P_PRECIO_VENTA", OracleType.Number).Value = p_precio_venta;
            agregar.Parameters.Add("P_STOCK_CRITICO", OracleType.Number).Value = p_stock_critico;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable modificar(int p_tipoproducto_id, string p_descripcion, int p_precio_compra, int p_precio_venta, int p_stock_critico)
        {
            OracleCommand modificar = new OracleCommand("PKG_TIPOPRODUCTO.PR_ACTUALIZAR_TIPOPRODUCTO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_TIPOPRODUCTO_ID", OracleType.Number).Value = p_tipoproducto_id;
            modificar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            modificar.Parameters.Add("P_PRECIO_COMPRA", OracleType.Number).Value = p_precio_compra;
            modificar.Parameters.Add("P_PRECIO_VENTA", OracleType.Number).Value = p_precio_venta;
            modificar.Parameters.Add("P_STOCK_CRITICO", OracleType.Number).Value = p_stock_critico;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable eliminar(int p_tipoproducto_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_TIPOPRODUCTO.PR_BORRAR_TIPOPRODUCTO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_TIPOPRODUCTO_ID", OracleType.VarChar).Value = p_tipoproducto_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

    }
}
