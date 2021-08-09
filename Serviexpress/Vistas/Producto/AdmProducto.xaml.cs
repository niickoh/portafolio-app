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


namespace Serviexpress.Vistas.Producto
{
    /// <summary>
    /// Lógica de interacción para AdmProducto.xaml
    /// </summary>
    public partial class AdmProducto : MetroWindow
    {
        public AdmProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
            dgAdmProductos.ItemsSource = negocio_Producto.listar_producto().DefaultView;

        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }

        private void btnAgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Producto.agregarProducto agregarProducto = new Vistas.Producto.agregarProducto();
            agregarProducto.Show();
        }

        private void btnEditarProducto_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Producto.modificarProducto modificarProducto = new Vistas.Producto.modificarProducto();
            modificarProducto.Show();
        }

        private void btnEliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Producto.eliminarProducto eliminarProducto = new Vistas.Producto.eliminarProducto();
            eliminarProducto.Show();
        }

        private void btnBuscarProducto_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
            dgAdmProductos.ItemsSource = negocio_Producto.buscar_producto(txtBuscarProducto.Text).DefaultView;
        }
    }
}
