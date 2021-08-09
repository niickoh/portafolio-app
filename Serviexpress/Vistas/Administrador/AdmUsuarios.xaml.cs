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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Serviexpress.Vistas.Administrador
{
    /// <summary>
    /// Lógica de interacción para AdmUsuarios.xaml
    /// </summary>
    public partial class AdmUsuarios : MetroWindow
    {
        public AdmUsuarios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Usuario usu_negocio = new Negocio_Serviexpress.Negocio_Usuario();
            dgUsuarios.ItemsSource = usu_negocio.listar_usuarios().DefaultView;
         }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Administrador.agregarUsuarios agregarUsuarios = new Vistas.Administrador.agregarUsuarios();
            agregarUsuarios.Show();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Administrador.modificarUsuarios modificarUsuarios = new Vistas.Administrador.modificarUsuarios();
            modificarUsuarios.Show();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Administrador.eliminarUsuarios eliminarUsuarios = new Vistas.Administrador.eliminarUsuarios();
            eliminarUsuarios.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }

        /*private void btnRefrescar_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_Usuario usu_negocio = new Negocio_Serviexpress.Negocio_Usuario();
            dgUsuarios.ItemsSource = usu_negocio.listar_usuarios().DefaultView;
        }*/

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_Usuario usu_negocio = new Negocio_Serviexpress.Negocio_Usuario();
            dgUsuarios.ItemsSource = usu_negocio.buscar_usuarios(txtBuscar.Text).DefaultView;
        }
    }
}
