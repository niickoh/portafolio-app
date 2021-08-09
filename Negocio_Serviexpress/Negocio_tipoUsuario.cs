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
    public class Negocio_tipoUsuario
    {
        /*public DataTable listar_tipo_usuario()
        {
            return new Datos_Serviexpress.Datos_tipoUsuario().tipoUsuario();
        }*/

        public DataTable listar_tipo_usuario_paquete()
        {
            return new Datos_Serviexpress.Datos_tipoUsuario().listar_con_paquete();
        }

        public DataTable buscar_tipo_usuario(string descripcion)
        {
            return new Datos_Serviexpress.Datos_tipoUsuario().buscar(descripcion);
        }

        public DataTable agregar_tipo_usuarios(string descripcion)
        {
            return new Datos_Serviexpress.Datos_tipoUsuario().agregar(descripcion);
        }

        public DataTable eliminar_tipo_usuario(int p_tipousuario_id)
        {
            return new Datos_Serviexpress.Datos_tipoUsuario().eliminar(p_tipousuario_id);
        }

        public DataTable modificar_tipo_usuario(int p_tipousuario_id, string p_descripcion)
        {
            return new Datos_Serviexpress.Datos_tipoUsuario().modificar(p_tipousuario_id, p_descripcion);
        }

        
    }
}
