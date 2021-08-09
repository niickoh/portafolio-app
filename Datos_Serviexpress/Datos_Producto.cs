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
    public class Datos_Producto
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        
        public DataTable listar()
        {
            string nombre = "";
            OracleCommand listar = new OracleCommand("PKG_PRODUCTO.PR_LISTAR_O_BUSCAR_PRODUCTO", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;
            listar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            listar.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;

        }

        public DataTable buscar(string nombre)
        {
            
            OracleCommand listar = new OracleCommand("PKG_PRODUCTO.PR_LISTAR_O_BUSCAR_PRODUCTO", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;            
            listar.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;

        }

        public DataTable agregar(int p_stock, DateTime p_fecha_vencimiento, string p_descripcion, int p_tipoproducto)
        {
            OracleCommand agregar = new OracleCommand("PKG_PRODUCTO.PR_AGREGAR_PRODUCTO", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_STOCK", OracleType.Number).Value = p_stock;
            agregar.Parameters.Add("P_FECHA_VENCIMIENTO", OracleType.DateTime).Value = p_fecha_vencimiento;
            agregar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            agregar.Parameters.Add("P_TIPOPRODUCTO", OracleType.Number).Value = p_tipoproducto;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;

        }


        public DataTable modificar(int p_producto_id, int p_stock, DateTime p_fecha_vencimiento, string p_descripcion, int p_tipoproducto)
        {
            OracleCommand modificar = new OracleCommand("PKG_PRODUCTO.PR_ACTUALIZAR_PRODUCTO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_PRODUCTO_ID", OracleType.Number).Value = p_producto_id;
            modificar.Parameters.Add("P_STOCK", OracleType.Number).Value = p_stock;
            modificar.Parameters.Add("P_FECHA_VENCIMIENTO", OracleType.DateTime).Value = p_fecha_vencimiento;
            modificar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            modificar.Parameters.Add("P_TIPOPRODUCTO", OracleType.Number).Value = p_tipoproducto;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;

        }

        public DataTable eliminar(int p_producto_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_PRODUCTO.PR_BORRAR_PRODUCTO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_PRODUCTO_ID", OracleType.Number).Value = p_producto_id;            

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;

        }





    }
}
