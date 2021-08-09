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
    public class Negocio_Producto
    {

        public DataTable listar_producto()
        {
            return new Datos_Serviexpress.Datos_Producto().listar();
        }

        public DataTable buscar_producto(string nombre)
        {
            return new Datos_Serviexpress.Datos_Producto().buscar(nombre);
        }

        public DataTable agregar_producto(int p_stock, DateTime p_fecha_vencimiento, string p_descripcion, int p_tipoproducto)
        {
            return new Datos_Serviexpress.Datos_Producto().agregar(p_stock, p_fecha_vencimiento, p_descripcion, p_tipoproducto);
        }

        public DataTable editar_producto(int p_producto_id, int p_stock, DateTime p_fecha_vencimiento, string p_descripcion, int p_tipoproducto)
        {
            return new Datos_Serviexpress.Datos_Producto().modificar(p_producto_id, p_stock, p_fecha_vencimiento, p_descripcion, p_tipoproducto);
        }

        public DataTable eliminar_producto(int p_producto_id)
        {
            return new Datos_Serviexpress.Datos_Producto().eliminar(p_producto_id);
        }
    }
}
