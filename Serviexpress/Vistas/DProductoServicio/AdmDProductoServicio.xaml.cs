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

namespace Serviexpress.Vistas.DProductoServicio
{
    /// <summary>
    /// Lógica de interacción para AdmDProductoServicio.xaml
    /// </summary>
    public partial class AdmDProductoServicio : MetroWindow
    {
        public AdmDProductoServicio()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_DProductoServicio negocio_DProductoServicio = new Negocio_Serviexpress.Negocio_DProductoServicio();
            dgDProductoServicio.ItemsSource = negocio_DProductoServicio.listar_d_producto_servicio().DefaultView;
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }

        private void btnBuscarDProductoServicio_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_DProductoServicio negocio_DProductoServicio = new Negocio_Serviexpress.Negocio_DProductoServicio();
            dgDProductoServicio.ItemsSource = negocio_DProductoServicio.buscar_d_producto_servicio(txtBuscarDProductoServicio.Text).DefaultView;
        }

        private void btnAgregarDProductoServicio_Click(object sender, RoutedEventArgs e)
        {
            Vistas.DProductoServicio.agregarDProductoServicio agregarDProductoServicio = new Vistas.DProductoServicio.agregarDProductoServicio();
            agregarDProductoServicio.Show();
        }

        private void btnEditarDProductoServicio_Click(object sender, RoutedEventArgs e)
        {
            Vistas.DProductoServicio.modificarDProductoServicio modificarDProductoServicio = new Vistas.DProductoServicio.modificarDProductoServicio();
            modificarDProductoServicio.Show();
        }

        private void btnEliminarDProductoServicio_Click(object sender, RoutedEventArgs e)
        {
            Vistas.DProductoServicio.eliminarDProductoServicio eliminarDProductoServicio = new Vistas.DProductoServicio.eliminarDProductoServicio();
            eliminarDProductoServicio.Show();
        }
    }
}
