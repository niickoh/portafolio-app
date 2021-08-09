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
    /// Lógica de interacción para AdmRecepcionProducto.xaml
    /// </summary>
    public partial class AdmRecepcionProducto : MetroWindow
    {
        public AdmRecepcionProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_RecepcionProducto negocio_RecepcionProducto = new Negocio_Serviexpress.Negocio_RecepcionProducto();
            dgRecepcionProductos.ItemsSource = negocio_RecepcionProducto.listar_recepcion_producto().DefaultView;
        }

        private void btnBuscarRecepcionProductos_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_RecepcionProducto negocio_RecepcionProducto = new Negocio_Serviexpress.Negocio_RecepcionProducto();
            dgRecepcionProductos.ItemsSource = negocio_RecepcionProducto.buscar_recepcion_producto(txtBuscarRecepcionProducto.Text).DefaultView;
        }

        private void btnAgregarRecepcionProductos_Click(object sender, RoutedEventArgs e)
        {
            Vistas.RecepcionProducto.agregarRecepcionProducto agregarRecepcionProducto = new Vistas.RecepcionProducto.agregarRecepcionProducto();
            agregarRecepcionProducto.Show();
        }

        private void btnEditarRecepcionProductos_Click(object sender, RoutedEventArgs e)
        {
            Vistas.RecepcionProducto.modificarRecepcionProducto modificarRecepcionProducto = new Vistas.RecepcionProducto.modificarRecepcionProducto();
            modificarRecepcionProducto.Show();
        }

        private void btnEliminarRecepcionProductos_Click(object sender, RoutedEventArgs e)
        {
            Vistas.RecepcionProducto.eliminarRecepcionProducto eliminarRecepcionProducto = new Vistas.RecepcionProducto.eliminarRecepcionProducto();
            eliminarRecepcionProducto.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }
    }
}
