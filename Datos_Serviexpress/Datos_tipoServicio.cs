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
    public class Datos_tipoServicio
    {

        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();

        public DataTable listar()
        {
            string descripcion = "";
            db.ConexionBD().Open();
            OracleCommand listar = new OracleCommand("PKG_TIPOSERVICIO.PR_LISTAR_O_BUSCAR_RESERVADEHORA", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;
            listar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            listar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = descripcion;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }
        public DataTable buscar(string descripcion)
        {

            db.ConexionBD().Open();
            OracleCommand buscar = new OracleCommand("PKG_TIPOSERVICIO.PR_LISTAR_O_BUSCAR_RESERVADEHORA", db.ConexionBD());
            buscar.CommandType = System.Data.CommandType.StoredProcedure;
            buscar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            buscar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = descripcion;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = buscar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable agregar(string p_descripcion, int p_precio)
        {
            OracleCommand agregar = new OracleCommand("PKG_TIPOSERVICIO.PR_AGREGAR_TIPOSERVICIO", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            agregar.Parameters.Add("P_PRECIO", OracleType.Number).Value = p_precio;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataTable modificar(int p_tiposervicio_id, string p_descripcion, int p_precio)
        {
            OracleCommand modificar = new OracleCommand("PKG_TIPOSERVICIO.PR_ACTUALIZAR_TIPOSERVICIO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_TIPOSERVICIO_ID", OracleType.Number).Value = p_tiposervicio_id;
            modificar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;
            modificar.Parameters.Add("P_PRECIO", OracleType.Number).Value = p_precio;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataTable eliminar(int p_tiposervicio_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_TIPOSERVICIO.PR_BORRAR_TIPOSERVICIO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_TIPOSERVICIO_ID", OracleType.Number).Value = p_tiposervicio_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
