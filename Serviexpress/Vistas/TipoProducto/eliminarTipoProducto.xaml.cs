using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Serviexpress.Vistas.TipoProducto
{
    /// <summary>
    /// Lógica de interacción para eliminarTipoProducto.xaml
    /// </summary>
    public partial class eliminarTipoProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarTipoProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoProducto negocio_TipoProducto = new Negocio_Serviexpress.Negocio_tipoProducto();
            cmbEliminarIDTipoProducto.ItemsSource = negocio_TipoProducto.listar_tipo_producto().DefaultView;
            cmbEliminarIDTipoProducto.DisplayMemberPath = "ID";
        }

        private async void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageDialogResult mensaje_salir = await this.ShowMessageAsync("¡Cuidado!", "¿Deseas salir?", MessageDialogStyle.AffirmativeAndNegative);
            if (mensaje_salir.Equals(MessageDialogResult.Affirmative))
            {
                this.Close();
            }
            else if (mensaje_salir.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar el Tipo de Producto?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoProducto negocio_TipoProducto = new Negocio_Serviexpress.Negocio_tipoProducto();
                    negocio_TipoProducto.eliminar_tipo_producto(int.Parse(cmbEliminarIDTipoProducto.Text));
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Tipo de Producto eliminado");
                    db.ConexionBD().Open();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Tipo de Producto NO eliminado");
                    this.Close();
                }


            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarIDTipoProducto.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes ingresar un ID para eliminar");
                }
            }
        }
    }
}
