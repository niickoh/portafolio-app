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

namespace Serviexpress.Vistas.DetPedidoProducto
{
    /// <summary>
    /// Lógica de interacción para AdmDetPedidoProducto.xaml
    /// </summary>
    public partial class AdmDetPedidoProducto : MetroWindow
    {
        public AdmDetPedidoProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_DetPedidoProducto negocio_DetPedidoProducto = new Negocio_Serviexpress.Negocio_DetPedidoProducto();
            dgDetPedidoProducto.ItemsSource = negocio_DetPedidoProducto.listar_det_pedido_producto().DefaultView;
        }

        private void txtBuscarDetPedidoProducto1_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_DetPedidoProducto negocio_DetPedidoProducto = new Negocio_Serviexpress.Negocio_DetPedidoProducto();
            dgDetPedidoProducto.ItemsSource = negocio_DetPedidoProducto.buscar_det_pedido_producto(txtBuscarDetPedidoProducto.Text).DefaultView;
        }

        private void btnAgregarDetPedidoProducto_Click(object sender, RoutedEventArgs e)
        {
            Vistas.DetPedidoProducto.agregarDetPedidoProducto agregarDetPedidoProducto = new Vistas.DetPedidoProducto.agregarDetPedidoProducto();
            agregarDetPedidoProducto.Show();
        }

        private void btnEditarDetPedidoProductos_Click(object sender, RoutedEventArgs e)
        {
            Vistas.DetPedidoProducto.modificarDetPedidoProducto modificarDetPedidoProducto = new Vistas.DetPedidoProducto.modificarDetPedidoProducto();
            modificarDetPedidoProducto.Show();
        }

        private void btnEliminarDetPedidoProductos_Click(object sender, RoutedEventArgs e)
        {
            Vistas.DetPedidoProducto.eliminarDetPedidoProducto eliminarDetPedidoProducto = new Vistas.DetPedidoProducto.eliminarDetPedidoProducto();
            eliminarDetPedidoProducto.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }
    }
}
