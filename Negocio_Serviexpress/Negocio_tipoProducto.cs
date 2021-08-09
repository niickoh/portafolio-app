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
    public class Negocio_tipoProducto
    {

        public DataTable listar_tipo_producto()
        {
            return new Datos_Serviexpress.Datos_tipoProducto().listar();
        } 

        public DataTable buscar_tipo_producto(string p_tipoproducto_id)
        {
            return new Datos_Serviexpress.Datos_tipoProducto().buscar(p_tipoproducto_id);
        }
        
        
        public DataTable agregar_tipo_producto(string p_descripcion, int p_precio_compra, int p_precio_venta, int p_stock_critico)
        {
            return new Datos_Serviexpress.Datos_tipoProducto().agregar(p_descripcion, p_precio_compra, p_precio_venta, p_stock_critico);
        }


        public DataTable editar_tipo_producto(int p_tipoproducto_id, string p_descripcion, int p_precio_compra, int p_precio_venta, int p_stock_critico)
        {
            return new Datos_Serviexpress.Datos_tipoProducto().modificar(p_tipoproducto_id, p_descripcion, p_precio_compra, p_precio_venta, p_stock_critico);
        }


        public DataTable eliminar_tipo_producto(int p_tipoproducto_id)
        {
            return new Datos_Serviexpress.Datos_tipoProducto().eliminar(p_tipoproducto_id);
        }
    }
}
