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
    public class Negocio_Servicios
    {

        public DataTable listar_servicios()
        {
            return new Datos_Serviexpress.Datos_Servicios().listar();
        }

        public DataTable buscar_servicios(string p_servicio_id)
        {
            return new Datos_Serviexpress.Datos_Servicios().buscar(p_servicio_id);
        }

        public DataTable agregar_servicios(string p_fecha, string p_comentario, int p_validado, int p_reservadehora_id)
        {
            return new Datos_Serviexpress.Datos_Servicios().agregar(p_fecha, p_comentario, p_validado, p_reservadehora_id);
        }


        public DataTable editar_servicios(int p_servicio_id, string p_fecha, string p_comentario, int p_validado, int p_reservadehora_id)
        {
            return new Datos_Serviexpress.Datos_Servicios().modificar(p_servicio_id, p_fecha, p_comentario, p_validado, p_reservadehora_id);
        }


        public DataTable eliminar_servicios(int p_servicio_id)
        {
            return new Datos_Serviexpress.Datos_Servicios().eliminar(p_servicio_id);
        }
    }
}
