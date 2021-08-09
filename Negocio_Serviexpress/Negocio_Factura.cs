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
    public class Negocio_Factura
    {

        public DataTable listar_factura()
        {
            return new Datos_Serviexpress.Datos_Factura().listar();
        }

        public DataTable buscar_factura(string p_factura_id)
        {
            return new Datos_Serviexpress.Datos_Factura().buscar(p_factura_id);
        }

        public DataTable agregar_factura(string p_fecha, int p_total, int p_validador, int p_ordendecompra_id)
        {
            return new Datos_Serviexpress.Datos_Factura().agregar(p_fecha, p_total, p_validador, p_ordendecompra_id);
        }

        public DataTable editar_factura(int p_factura_id, string p_fecha, int p_total, int p_validador, int p_ordendecompra_id)
        {
            return new Datos_Serviexpress.Datos_Factura().modificar(p_factura_id, p_fecha, p_total, p_validador, p_ordendecompra_id);
        }

        public DataTable eliminar_factura(int p_factura_id)
        {
            return new Datos_Serviexpress.Datos_Factura().eliminar(p_factura_id);
        }
    }
}
