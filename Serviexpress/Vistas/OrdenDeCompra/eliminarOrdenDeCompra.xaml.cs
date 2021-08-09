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

namespace Serviexpress.Vistas.OrdenDeCompra
{
    /// <summary>
    /// Lógica de interacción para eliminarOrdenDeCompra.xaml
    /// </summary>
    public partial class eliminarOrdenDeCompra : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarOrdenDeCompra()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
            cmbEliminarIDOrdenCompra.ItemsSource = negocio_OrdenDeCompra.listar_orden_de_compra().DefaultView;
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

        private async void btnEliminarOrdenCompra_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar la Orden de compra seleccionada?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
                    negocio_OrdenDeCompra.eliminar_orden_de_compra(int.Parse(cmbEliminarIDOrdenCompra.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Orden de Compra eliminada");
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Orden de Compra NO eliminada");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarIDOrdenCompra.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes seleccionar un ID para eliminar");
                }
            }
        }
    }
}
