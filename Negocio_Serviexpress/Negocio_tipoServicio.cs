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
    public class Negocio_tipoServicio
    {

        public DataTable listar_tipo_servicio()
        {
            return new Datos_Serviexpress.Datos_tipoServicio().listar();
        }

        public DataTable buscar_tipo_servicio(string descripcion)
        {
            return new Datos_Serviexpress.Datos_tipoServicio().buscar(descripcion);
        }

        public DataTable agregar_tipo_servicio(string p_descripcion, int p_precio)
        {
            return new Datos_Serviexpress.Datos_tipoServicio().agregar(p_descripcion, p_precio);
        }

        public DataTable editar_tipo_servicio(int p_tiposervicio_id, string p_descripcion, int p_precio)
        {
            return new Datos_Serviexpress.Datos_tipoServicio().modificar(p_tiposervicio_id, p_descripcion, p_precio);
        }

        public DataTable eliminar_tipo_servicio(int p_tiposervicio_id)
        {
            return new Datos_Serviexpress.Datos_tipoServicio().eliminar(p_tiposervicio_id);
        }
    }
}
