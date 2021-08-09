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
    /// Lógica de interacción para agregarRecepcionProducto.xaml
    /// </summary>
    public partial class agregarRecepcionProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public agregarRecepcionProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
            cmbIDOrdenCompra.ItemsSource = negocio_OrdenDeCompra.listar_orden_de_compra().DefaultView;
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

        private async void btnAgregarRecepcionProductos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de agregar una nueva recepcion de productos?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_RecepcionProducto negocio_RecepcionProducto = new Negocio_Serviexpress.Negocio_RecepcionProducto();
                    negocio_RecepcionProducto.agregar_recepcion_producto(dpFecha.Text, int.Parse(txtAgregarValidador.Text), txtAgregarDescripcion.Text, int.Parse(cmbIDOrdenCompra.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Recepción de Productos agregada");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Recepción de Productos NO agregada");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(dpFecha.Text) || string.IsNullOrEmpty(txtAgregarValidador.Text) || string.IsNullOrEmpty(txtAgregarDescripcion.Text) || string.IsNullOrEmpty(cmbIDOrdenCompra.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para agregar");
                }
            }
        }
    }
}
