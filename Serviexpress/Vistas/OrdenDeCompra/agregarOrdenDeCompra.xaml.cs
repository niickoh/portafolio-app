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
    /// Lógica de interacción para agregarOrdenDeCompra.xaml
    /// </summary>
    public partial class agregarOrdenDeCompra : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public agregarOrdenDeCompra()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Usuario negocio_Usuario = new Negocio_Serviexpress.Negocio_Usuario();
            cmbIDUsuario.ItemsSource = negocio_Usuario.listar_usuarios().DefaultView;
            cmbIDUsuario.DisplayMemberPath = "ID";
            Negocio_Serviexpress.Negocio_Proveedor negocio_Proveedor = new Negocio_Serviexpress.Negocio_Proveedor();
            cmbIDProveedor.ItemsSource = negocio_Proveedor.listar_proveedor().DefaultView;
            cmbIDProveedor.DisplayMemberPath = "ID";
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
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de agregar una nueva orden de compra?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
                    negocio_OrdenDeCompra.agregar_orden_de_compra(int.Parse(cmbIDUsuario.Text), int.Parse(cmbIDProveedor.Text), dpFechaSolicitud.Text, 
                                                                  txtDescripcion.Text, int.Parse(txtTotal.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Orden de Compra agregada");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Orden de Compra NO agregada");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbIDUsuario.Text) || string.IsNullOrEmpty(cmbIDProveedor.Text) || string.IsNullOrEmpty(dpFechaSolicitud.Text) ||
                    string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtTotal.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para agregar");
                }
            }
        }
    }
}
