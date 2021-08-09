using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;

namespace Negocio_Serviexpress
{
    public class Negocio_Usuario
    {
        
        public DataTable Logueo(string usuario, string contrasena)
        {
            return new Datos_Serviexpress.Datos_Usuario().inicio(usuario, contrasena);
            
        }

        public DataTable listar_usuarios()
        {
            return new Datos_Serviexpress.Datos_Usuario().listar();
        }

        public DataTable buscar_usuarios(string rut)
        {
            
            return new Datos_Serviexpress.Datos_Usuario().buscar(rut);
        }
        
        public DataTable agregar_usuarios(int p_tipousuario_id, string p_nombre, string p_contra, string p_email, string p_pnombre, string p_snombre, string p_apaterno, string p_amaterno, int p_rut, string p_dv, string fechanac)
        {
             return new Datos_Serviexpress.Datos_Usuario().insertar(p_tipousuario_id, p_nombre, p_contra, p_email, p_pnombre, p_snombre, p_apaterno, p_amaterno, p_rut, p_dv, fechanac);
        }


        public DataTable modificar_usuarios(int id, int p_tipousuario_id, string p_nombre, string p_contra, string p_email, string p_pnombre, string p_snombre, string p_apaterno, string p_amaterno, int p_rut, string p_dv, string fechanac)
        {
            return new Datos_Serviexpress.Datos_Usuario().modificar(id, p_tipousuario_id, p_nombre, p_contra, p_email, p_pnombre, p_snombre, p_apaterno, p_amaterno, p_rut, p_dv, fechanac);
        }

        public DataTable eliminar_usuarios(int id)
        {
            return new Datos_Serviexpress.Datos_Usuario().eliminar(id);
        }
    }
}
