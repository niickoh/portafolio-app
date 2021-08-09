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

namespace Serviexpress.Vistas.Administrador
{
    /// <summary>
    /// Lógica de interacción para Administracion.xaml
    /// </summary>
    public partial class Administracion : MetroWindow
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void tlUsuarios_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.AdmUsuarios admUsuarios = new Vistas.Administrador.AdmUsuarios();
            admUsuarios.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administrador administrador = new Vistas.Administrador.Administrador();
            administrador.ShowDialog();
            
        }

        private void tlTipoUsuarios_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.TipoUsuario.AdmTipoUsuarios admTipoUsuarios = new Vistas.TipoUsuario.AdmTipoUsuarios();
            admTipoUsuarios.Show();
        }

        private void tlProducto_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Producto.AdmProducto admProducto = new Vistas.Producto.AdmProducto();
            admProducto.Show();
        }

        private void tlTipoProducto_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.TipoProducto.AdmTipoProducto admTipoProducto = new Vistas.TipoProducto.AdmTipoProducto();
            admTipoProducto.Show();
        }

        private void tlTipoRubro_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.TipoRubro.AdmTipoRubro admTipoRubro = new Vistas.TipoRubro.AdmTipoRubro();
            admTipoRubro.Show();
        }

        private void tlReserva_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.ReservaHora.AdmReservaHora admReservaHora = new Vistas.ReservaHora.AdmReservaHora();
            admReservaHora.Show();
        }

        private void tlTipoServicio_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.TipoServicio.AdmTipoServicio admTipoServicio = new Vistas.TipoServicio.AdmTipoServicio();
            admTipoServicio.Show();
        }

        private void tlServicios_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Servicios.AdmServicios admServicios = new Vistas.Servicios.AdmServicios();
            admServicios.Show();
        }

        private void tlProveedor_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Proveedor.admProveedor admProveedor = new Vistas.Proveedor.admProveedor();
            admProveedor.Show();
        }

        private void lblOrdenCompra_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.OrdenDeCompra.AdmOrdenDeCompra admOrdenDeCompra = new Vistas.OrdenDeCompra.AdmOrdenDeCompra();
            admOrdenDeCompra.Show();
        }

        private void tlRecepcion_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.RecepcionProducto.AdmRecepcionProducto admRecepcionProducto = new Vistas.RecepcionProducto.AdmRecepcionProducto();
            admRecepcionProducto.Show();
        }

        private void tlDetallePedidoPro_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.DetPedidoProducto.AdmDetPedidoProducto admDetPedidoProducto = new Vistas.DetPedidoProducto.AdmDetPedidoProducto();
            admDetPedidoProducto.Show();
        }

        private void tlDetalleProductoServicio_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.DProductoServicio.AdmDProductoServicio admDProductoServicio = new Vistas.DProductoServicio.AdmDProductoServicio();
            admDProductoServicio.Show();
        }
    }
}
