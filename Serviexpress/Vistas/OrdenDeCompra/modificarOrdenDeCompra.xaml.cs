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
    /// Lógica de interacción para modificarOrdenDeCompra.xaml
    /// </summary>
    public partial class modificarOrdenDeCompra : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarOrdenDeCompra()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Usuario negocio_Usuario = new Negocio_Serviexpress.Negocio_Usuario();
            cmbEditarIDUsuario.ItemsSource = negocio_Usuario.listar_usuarios().DefaultView;
            cmbEditarIDUsuario.DisplayMemberPath = "ID";
            Negocio_Serviexpress.Negocio_Proveedor negocio_Proveedor = new Negocio_Serviexpress.Negocio_Proveedor();
            cmbEditarIDProveedor.ItemsSource = negocio_Proveedor.listar_proveedor().DefaultView;
            cmbEditarIDProveedor.DisplayMemberPath = "ID";
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

        private async void btnAgregarOrdenCompra_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar la orden de compra?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
                    negocio_OrdenDeCompra.editar_orden_de_compra(int.Parse(txtEditarIDOrdenCompra.Text), int.Parse(cmbEditarIDUsuario.Text), int.Parse(cmbEditarIDProveedor.Text),
                                                                 dpEditarFechaSolicitud.Text, txtEditarDescripcion.Text, int.Parse(txtEditarTotal.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Orden de Compra editada");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Orden de Compra NO editada");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtEditarIDOrdenCompra.Text) || string.IsNullOrEmpty(cmbEditarIDUsuario.Text) || string.IsNullOrEmpty(cmbEditarIDProveedor.Text) ||
                    string.IsNullOrEmpty(dpEditarFechaSolicitud.Text) || string.IsNullOrEmpty(txtEditarDescripcion.Text) || string.IsNullOrEmpty(txtEditarTotal.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }
            }
        }
    }
}
