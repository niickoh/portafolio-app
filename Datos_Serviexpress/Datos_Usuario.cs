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
    public class Datos_Usuario
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public DataTable inicio(string usuario, string contrasena)
        {
            db.ConexionBD().Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM usuarioescritorio JOIN tipousuario ON usuarioescritorio.tipousuario_id = tipousuario.id WHERE usuarioescritorio.nombre_usuario = :usuario AND usuarioescritorio.contrasena = :contra", db.ConexionBD());
            comando.Parameters.Add("usuario", OracleType.VarChar).Value = usuario;
            comando.Parameters.Add("contra", OracleType.VarChar).Value = contrasena;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
            
        }

        public DataTable listar()
        {
            string rut = "";
            db.ConexionBD().Open();
            OracleCommand comando = new OracleCommand("PKG_USUARIO.PR_LISTAR_O_BUSCAR_USUARIO", db.ConexionBD());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("p_datos", OracleType.Cursor).Direction= ParameterDirection.Output;
            comando.Parameters.Add("v_rut", OracleType.VarChar).Value = rut;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }


        public DataTable buscar(string rut)
        {
            
            db.ConexionBD().Open();
            OracleCommand comando = new OracleCommand("PKG_USUARIO.PR_LISTAR_O_BUSCAR_USUARIO", db.ConexionBD());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("p_datos", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("v_rut", OracleType.VarChar).Value = rut;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;

        }



        public DataTable insertar(int p_tipousuario_id, string p_nombre, string p_contra, string p_email, string p_pnombre, string p_snombre, string p_apaterno, string p_amaterno, int p_rut, string p_dv, string p_fechanac)
        {


            OracleCommand comando = new OracleCommand("PKG_USUARIO.PR_AGREGAR_USUARIO", db.ConexionBD());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("p_tipousuario_id", OracleType.Int32).Value = p_tipousuario_id;
            comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = p_nombre;
            comando.Parameters.Add("p_contra", OracleType.VarChar).Value = p_contra;
            comando.Parameters.Add("p_email", OracleType.VarChar).Value = p_email;
            comando.Parameters.Add("p_pnombre", OracleType.VarChar).Value = p_pnombre;
            comando.Parameters.Add("p_snombre", OracleType.VarChar).Value = p_snombre;
            comando.Parameters.Add("p_apaterno", OracleType.VarChar).Value = p_apaterno;
            comando.Parameters.Add("p_amaterno", OracleType.VarChar).Value = p_amaterno;
            comando.Parameters.Add("p_rut", OracleType.Int32).Value = p_rut;
            comando.Parameters.Add("p_dv", OracleType.VarChar).Value = p_dv;
            comando.Parameters.Add("p_fechanac", OracleType.VarChar).Value = p_fechanac;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


        public DataTable modificar(int id, int p_tipousuario_id, string p_nombre, string p_contra, string p_email, string p_pnombre, string p_snombre, string p_apaterno, string p_amaterno, int p_rut, string p_dv, string p_fechanac)
        {
            OracleCommand modificar = new OracleCommand("PKG_USUARIO.PR_ACTUALIZAR_USUARIO", db.ConexionBD());
            modificar.CommandType = System.Data.CommandType.StoredProcedure;
            modificar.Parameters.Add("p_usuario_id", OracleType.Int32).Value = id;
            modificar.Parameters.Add("p_tipousuario_id", OracleType.Int32).Value = p_tipousuario_id;
            modificar.Parameters.Add("p_nombre", OracleType.VarChar).Value = p_nombre;
            modificar.Parameters.Add("p_contra", OracleType.VarChar).Value = p_contra;
            modificar.Parameters.Add("p_email", OracleType.VarChar).Value = p_email;
            modificar.Parameters.Add("p_pnombre", OracleType.VarChar).Value = p_pnombre;
            modificar.Parameters.Add("p_snombre", OracleType.VarChar).Value = p_snombre;
            modificar.Parameters.Add("p_apaterno", OracleType.VarChar).Value = p_apaterno;
            modificar.Parameters.Add("p_amaterno", OracleType.VarChar).Value = p_amaterno;
            modificar.Parameters.Add("p_rut", OracleType.Int32).Value = p_rut;
            modificar.Parameters.Add("p_dv", OracleType.VarChar).Value = p_dv;
            modificar.Parameters.Add("p_fechanac", OracleType.VarChar).Value = p_fechanac;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = modificar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataTable eliminar(int id)
        {
            OracleCommand eliminar = new OracleCommand("PKG_USUARIO.PR_BORRAR_USUARIO", db.ConexionBD());
            eliminar.CommandType = System.Data.CommandType.StoredProcedure;
            eliminar.Parameters.Add("P_USUARIO_ID", OracleType.Int32).Value = id;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = eliminar;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }


    }
}
