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

namespace Serviexpress.Vistas.Servicios
{
    /// <summary>
    /// Lógica de interacción para AdmServicios.xaml
    /// </summary>
    public partial class AdmServicios : MetroWindow
    {
        public AdmServicios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Servicios negocio_Servicios = new Negocio_Serviexpress.Negocio_Servicios();
            dgServicios.ItemsSource = negocio_Servicios.listar_servicios().DefaultView;
            
        }

        private void btnAgregarServicios_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Servicios.agregarServicios agregarServicios = new Vistas.Servicios.agregarServicios();
            agregarServicios.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }

        private void btnBuscarServicios_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_Servicios negocio_Servicios = new Negocio_Serviexpress.Negocio_Servicios();
            dgServicios.ItemsSource = negocio_Servicios.buscar_servicios(txtBuscarServicios.Text).DefaultView;
        }
    }
}
