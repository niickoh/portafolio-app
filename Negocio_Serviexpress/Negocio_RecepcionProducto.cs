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
    public class Negocio_RecepcionProducto
    { 
        public DataTable listar_recepcion_producto()
        {
            return new Datos_Serviexpress.Datos_RecepcionProducto().listar();
        }

        public DataTable buscar_recepcion_producto(string p_recepcionproducto_id)
        {
            return new Datos_Serviexpress.Datos_RecepcionProducto().buscar(p_recepcionproducto_id);
        }

        public DataTable agregar_recepcion_producto(string p_fecha, int p_validador, string p_descripcion, int p_ordendecompra_id)
        {
            return new Datos_Serviexpress.Datos_RecepcionProducto().agregar(p_fecha, p_validador, p_descripcion, p_ordendecompra_id);
        }

        public DataTable editar_recepcion_producto(int p_recepcionproducto_id, string p_fecha, int p_validador, string p_descripcion, int p_ordendecompra_id)
        {
            return new Datos_Serviexpress.Datos_RecepcionProducto().modificar(p_recepcionproducto_id, p_fecha, p_validador, p_descripcion, p_ordendecompra_id);
        }

        public DataTable eliminar_recepcion_producto(int p_recepcionproducto_id)
        {
            return new Datos_Serviexpress.Datos_RecepcionProducto().eliminar(p_recepcionproducto_id);
        }



    }
}
