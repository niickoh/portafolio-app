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
    public class Negocio_tipoRubro
    {
        public DataTable listar_tipo_rubro()
        {
            return new Datos_Serviexpress.Datos_tipoRubro().listar();
        }

        public DataTable buscar_tipo_rubro(string p_tiporubro_id)
        {
            return new Datos_Serviexpress.Datos_tipoRubro().buscar(p_tiporubro_id);
        }

        public DataTable agregar_tipo_rubro(string descripcion)
        {
            return new Datos_Serviexpress.Datos_tipoRubro().agregar(descripcion);
        }

        public DataTable editar_tipo_rubro(int p_tiporubro_id, string p_descripcion)
        {
            return new Datos_Serviexpress.Datos_tipoRubro().modificar(p_tiporubro_id, p_descripcion);
        }

        public DataTable eliminar_tipo_rubro(int p_tiporubro_id)
        {
            return new Datos_Serviexpress.Datos_tipoRubro().eliminar(p_tiporubro_id);
        }


    }
}
