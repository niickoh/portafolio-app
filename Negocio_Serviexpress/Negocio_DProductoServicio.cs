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
    public class Negocio_DProductoServicio
    {
        public DataTable listar_d_producto_servicio()
        {
            return new Datos_Serviexpress.Datos_DProductoServicio().listar();
        }

        public DataTable buscar_d_producto_servicio(string p_servicio_id)
        {
            return new Datos_Serviexpress.Datos_DProductoServicio().buscar(p_servicio_id);
        }

        public DataTable agregar_d_producto_servicio(int p_cantidad, int p_servicio_id, int p_producto_id)
        {
            return new Datos_Serviexpress.Datos_DProductoServicio().agregar(p_cantidad, p_servicio_id, p_producto_id);
        }

        public DataTable editar_d_producto_servicio(int p_id, int p_cantidad, int p_servicio_id, int p_producto_id)
        {
            return new Datos_Serviexpress.Datos_DProductoServicio().modificar(p_id, p_cantidad, p_servicio_id, p_producto_id);
        }

        public DataTable eliminar_d_producto_servicio(int p_id)
        {
            return new Datos_Serviexpress.Datos_DProductoServicio().eliminar(p_id);
        }

    }
}
