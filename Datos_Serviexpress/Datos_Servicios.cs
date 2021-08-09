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
    public class Datos_Servicios
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public DataTable listar()
        {
            string p_servicio_id = "";
            db.ConexionBD().Open();
            OracleCommand listar = new OracleCommand("PKG_SERVICIO.PR_LISTAR_O_BUSCAR_SERVICIO", db.ConexionBD());
            listar.CommandType = System.Data.CommandType.StoredProcedure;
            listar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            listar.Parameters.Add("P_SERVICIO_ID", OracleType.VarChar).Value = p_servicio_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = listar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable buscar(string p_servicio_id)
        {

            db.ConexionBD().Open();
            OracleCommand buscar = new OracleCommand("PKG_SERVICIO.PR_LISTAR_O_BUSCAR_SERVICIO", db.ConexionBD());
            buscar.CommandType = System.Data.CommandType.StoredProcedure;
            buscar.Parameters.Add("P_DATOS", OracleType.Cursor).Direction = ParameterDirection.Output;
            buscar.Parameters.Add("P_SERVICIO_ID", OracleType.VarChar).Value = p_servicio_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = buscar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable agregar(string p_fecha, string p_comentario, int p_validado, int p_reservadehora_id)
        {
            OracleCommand agregar = new OracleCommand("PKG_SERVICIO.PR_AGREGAR_SERVICIO", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("P_FECHA", OracleType.VarChar).Value = p_fecha;
            agregar.Parameters.Add("P_COMENTARIO", OracleType.VarChar).Value = p_comentario;
            agregar.Parameters.Add("P_VALIDADO", OracleType.Number).Value = p_validado;
            agregar.Parameters.Add("P_RESERVADEHORA_ID", OracleType.Number).Value = p_reservadehora_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable modificar(int p_servicio_id, string p_fecha, string p_comentario, int p_validado, int p_reservadehora_id)
        {
            OracleCommand modificar = new OracleCommand("PKG_SERVICIO.PR_ACTUALIZAR_SERVICIO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_SERVICIO_ID", OracleType.Number).Value = p_servicio_id;
            modificar.Parameters.Add("P_FECHA", OracleType.VarChar).Value = p_fecha;
            modificar.Parameters.Add("P_COMENTARIO", OracleType.VarChar).Value = p_comentario;
            modificar.Parameters.Add("P_VALIDADO", OracleType.Number).Value = p_validado;
            modificar.Parameters.Add("P_RESERVADEHORA_ID", OracleType.Number).Value = p_reservadehora_id;
            

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable eliminar(int p_servicio_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_SERVICIO.PR_BORRAR_SERVICIO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_SERVICIO_ID", OracleType.Number).Value = p_servicio_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
