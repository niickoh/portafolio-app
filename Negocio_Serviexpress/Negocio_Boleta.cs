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
    public class Negocio_Boleta
    {

        public DataTable listar_boleta()
        {
            return new Datos_Serviexpress.Datos_Boleta().listar();
        }

        public DataTable buscar_boleta(string p_boleta_id)
        {
            return new Datos_Serviexpress.Datos_Boleta().buscar(p_boleta_id);
        }


        public DataTable agregar_boleta(int p_servicio_id, string p_fecha, string p_comentario, int p_total)
        {
            return new Datos_Serviexpress.Datos_Boleta().agregar(p_servicio_id, p_fecha, p_comentario, p_total);
        }


        public DataTable editar_boleta(int p_boleta_id, int p_servicio_id, string p_fecha, string p_comentario, int p_total)
        {
            return new Datos_Serviexpress.Datos_Boleta().modificar(p_boleta_id, p_servicio_id, p_fecha, p_comentario, p_total);
        }


        public DataTable eliminar_boleta(int p_boleta_id)
        {
            return new Datos_Serviexpress.Datos_Boleta().eliminar(p_boleta_id);
        }

    }
}
