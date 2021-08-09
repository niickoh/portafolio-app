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
    public class Negocio_DetPedidoProducto
    {

        public DataTable listar_det_pedido_producto()
        {
            return new Datos_Serviexpress.Datos_DetPedidoProducto().listar();
        }


        public DataTable buscar_det_pedido_producto(string p_ordendecompra_id)
        {
            return new Datos_Serviexpress.Datos_DetPedidoProducto().buscar(p_ordendecompra_id);
        }


        public DataTable agregar_det_pedido_producto(int p_cantidad, int p_ordendecompra_id, int p_producto_id)
        {
            return new Datos_Serviexpress.Datos_DetPedidoProducto().agregar(p_cantidad, p_ordendecompra_id, p_producto_id);
        }


        public DataTable editar_det_pedido_producto(int p_detpedidoproducto_id, int p_cantidad, int p_ordendecompra_id, int p_producto_id)
        {
            return new Datos_Serviexpress.Datos_DetPedidoProducto().modificar(p_detpedidoproducto_id, p_cantidad, p_ordendecompra_id, p_producto_id);
        }


        public DataTable eliminar_det_pedido_producto(int p_detpedidoproducto_id)
        {
            return new Datos_Serviexpress.Datos_DetPedidoProducto().eliminar(p_detpedidoproducto_id);
        }
    }
}
