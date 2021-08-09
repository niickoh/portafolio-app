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
    public class Datos_tipoUsuario
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        
        public DataTable listar_con_paquete()
        {
            string descripcion = "";
            db.ConexionBD().Open();
            OracleCommand comando = new OracleCommand("PKG_TIPOUSUARIO.PR_LISTAR_O_BUSCAR_TIPOUSUARIO", db.ConexionBD());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("p_datos", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("p_descripcion", OracleType.VarChar).Value = descripcion;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }
        public DataTable buscar(string descripcion)
        {
            
            db.ConexionBD().Open();
            OracleCommand comando = new OracleCommand("PKG_TIPOUSUARIO.PR_LISTAR_O_BUSCAR_TIPOUSUARIO", db.ConexionBD());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("p_datos", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("p_descripcion", OracleType.VarChar).Value = descripcion;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable agregar(string descripcion)
        {
            OracleCommand agregar = new OracleCommand("PKG_TIPOUSUARIO.PR_AGREGAR_TIPOUSUARIO", db.ConexionBD());
            agregar.CommandType = System.Data.CommandType.StoredProcedure;
            agregar.Parameters.Add("p_descripcion", OracleType.VarChar).Value = descripcion;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = agregar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataTable eliminar(int p_tipousuario_id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_TIPOUSUARIO.PR_BORRAR_TIPOUSUARIO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_TIPOUSUARIO_ID", OracleType.Number).Value = p_tipousuario_id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataTable modificar(int p_tipousuario_id, string p_descripcion)
        {
            OracleCommand modificar = new OracleCommand("PKG_TIPOUSUARIO.PR_ACTUALIZAR_TIPOUSUARIO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("P_TIPOUSUARIO_ID", OracleType.Number).Value = p_tipousuario_id;
            modificar.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = p_descripcion;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
