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
    public class Negocio_Proveedor
    {

        public DataTable listar_proveedor()
        {
            return new Datos_Serviexpress.Datos_Proveedor().listar();
        }


        public DataTable buscar_proveedor(string p_nombre)
        {
            return new Datos_Serviexpress.Datos_Proveedor().buscar(p_nombre);
        }


        public DataTable agregar_proveedor(int p_tiporubro_id, string p_nombre, int p_telefono, string p_email)
        {
            return new Datos_Serviexpress.Datos_Proveedor().agregar(p_tiporubro_id, p_nombre, p_telefono, p_email);
        }


        public DataTable modificar_proveedor(int p_proveedor_id, int p_tiporubro_id, string p_nombre, int p_telefono, string p_email)
        {
            return new Datos_Serviexpress.Datos_Proveedor().modificar(p_proveedor_id, p_tiporubro_id, p_nombre, p_telefono, p_email);
        }


        public DataTable eliminar_proveedor(int p_proveedor_id)
        {
            return new Datos_Serviexpress.Datos_Proveedor().eliminar(p_proveedor_id);
        }

    }
}
