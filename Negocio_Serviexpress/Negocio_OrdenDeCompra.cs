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
    public class Negocio_OrdenDeCompra
    {

        public DataTable listar_orden_de_compra()
        {
            return new Datos_Serviexpress.Datos_OrdenDeCompra().listar();
        }

        public DataTable buscar_orden_de_compra(string p_ordendecompra_id)
        {
            return new Datos_Serviexpress.Datos_OrdenDeCompra().buscar(p_ordendecompra_id);
        }

        public DataTable agregar_orden_de_compra(int p_usuarioescritorio_id, int p_proveedor_id, string p_fecha_solicitud, string p_descripcion, int p_total)
        {
            return new Datos_Serviexpress.Datos_OrdenDeCompra().agregar(p_usuarioescritorio_id, p_proveedor_id, p_fecha_solicitud, p_descripcion, p_total);
        }

        public DataTable editar_orden_de_compra(int p_ordendecompra_id, int p_usuarioescritorio_id, int p_proveedor_id, string p_fecha_solicitud, string p_descripcion, int p_total)
        {
            return new Datos_Serviexpress.Datos_OrdenDeCompra().modificar(p_ordendecompra_id, p_usuarioescritorio_id, p_proveedor_id, p_fecha_solicitud, p_descripcion, p_total);
        }

        public DataTable eliminar_orden_de_compra(int p_ordendecompra_id)
        {
            return new Datos_Serviexpress.Datos_OrdenDeCompra().eliminar(p_ordendecompra_id);
        }


    }
}
