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
    /// Lógica de interacción para AdmOrdenDeCompra.xaml
    /// </summary>
    public partial class AdmOrdenDeCompra : MetroWindow
    {
        public AdmOrdenDeCompra()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
            dgOrdenesCompra.ItemsSource = negocio_OrdenDeCompra.listar_orden_de_compra().DefaultView;
        }

        private void btnAgregarOrdenCompra_Click(object sender, RoutedEventArgs e)
        {
            Vistas.OrdenDeCompra.agregarOrdenDeCompra agregarOrdenDeCompra = new Vistas.OrdenDeCompra.agregarOrdenDeCompra();
            agregarOrdenDeCompra.Show();
        }

        private void btnEditarOrdenCompra_Click(object sender, RoutedEventArgs e)
        {
            Vistas.OrdenDeCompra.modificarOrdenDeCompra modificarOrdenDeCompra = new Vistas.OrdenDeCompra.modificarOrdenDeCompra();
            modificarOrdenDeCompra.Show();
        }

        private void btnEliminarOrdenCompra_Click(object sender, RoutedEventArgs e)
        {
            Vistas.OrdenDeCompra.eliminarOrdenDeCompra eliminarOrdenDeCompra = new Vistas.OrdenDeCompra.eliminarOrdenDeCompra();
            eliminarOrdenDeCompra.Show();
        }

        private void btnBuscarOrdenCompra_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
            dgOrdenesCompra.ItemsSource = negocio_OrdenDeCompra.buscar_orden_de_compra(txtBuscarOrdenCompra.Text).DefaultView;
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }
    }
}
