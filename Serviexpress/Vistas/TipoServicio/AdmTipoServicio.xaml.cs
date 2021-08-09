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

namespace Serviexpress.Vistas.TipoServicio
{
    /// <summary>
    /// Lógica de interacción para AdmTipoServicio.xaml
    /// </summary>
    public partial class AdmTipoServicio : MetroWindow
    {
        public AdmTipoServicio()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoServicio negocio_TipoServicio = new Negocio_Serviexpress.Negocio_tipoServicio();
            dgTipoServicios.ItemsSource = negocio_TipoServicio.listar_tipo_servicio().DefaultView;
        }

        private void btnAgregarTS_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoServicio.agregarTipoServicio agregarTipoServicio = new Vistas.TipoServicio.agregarTipoServicio();
            agregarTipoServicio.Show();
        }

        private void btnEditarTS_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoServicio.modificarTipoServicio modificarTipoServicio = new Vistas.TipoServicio.modificarTipoServicio();
            modificarTipoServicio.Show();
        }

        private void btnEliminarTS_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoServicio.eliminarTipoServicio eliminarTipoServicio = new Vistas.TipoServicio.eliminarTipoServicio();
            eliminarTipoServicio.Show();
        }

        private void btnBuscarTS_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_tipoServicio negocio_TipoServicio = new Negocio_Serviexpress.Negocio_tipoServicio();
            dgTipoServicios.ItemsSource = negocio_TipoServicio.buscar_tipo_servicio(txtBuscatTS.Text).DefaultView;
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }
    }
}
