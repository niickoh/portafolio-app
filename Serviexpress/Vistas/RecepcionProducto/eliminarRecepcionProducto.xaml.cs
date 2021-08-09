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

namespace Serviexpress.Vistas.RecepcionProducto
{
    /// <summary>
    /// Lógica de interacción para eliminarRecepcionProducto.xaml
    /// </summary>
    public partial class eliminarRecepcionProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarRecepcionProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_RecepcionProducto negocio_RecepcionProducto = new Negocio_Serviexpress.Negocio_RecepcionProducto();
            cmbEliminarIDRecepcionProductos.ItemsSource = negocio_RecepcionProducto.listar_recepcion_producto().DefaultView;
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

        private async void btnEliminarRecepcionProductos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar la recepción de productos seleccionada?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_RecepcionProducto negocio_RecepcionProducto = new Negocio_Serviexpress.Negocio_RecepcionProducto();
                    negocio_RecepcionProducto.eliminar_recepcion_producto(int.Parse(cmbEliminarIDRecepcionProductos.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Recepcion de productos eliminada");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Recepcion de productos NO eliminada");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarIDRecepcionProductos.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes seleccionar un ID para eliminar");
                }
            }
        }
    }
}
