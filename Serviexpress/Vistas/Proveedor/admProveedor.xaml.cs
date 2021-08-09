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

namespace Serviexpress.Vistas.Proveedor
{
    /// <summary>
    /// Lógica de interacción para admProveedor.xaml
    /// </summary>
    public partial class admProveedor : MetroWindow
    {
        public admProveedor()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Proveedor negocio_Proveedor = new Negocio_Serviexpress.Negocio_Proveedor();
            dgProveedores.ItemsSource = negocio_Proveedor.listar_proveedor().DefaultView;
        }

        private void btnAgregarProveedor_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Proveedor.agregarProveedor agregarProveedor = new Vistas.Proveedor.agregarProveedor();
            agregarProveedor.Show();
        }

        private void btnBuscarAdmProveedor_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_Proveedor negocio_Proveedor = new Negocio_Serviexpress.Negocio_Proveedor();
            dgProveedores.ItemsSource = negocio_Proveedor.buscar_proveedor(txtBuscarProveedor.Text).DefaultView;
        }

        private void btnEditarProveedor_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Proveedor.modificarProveedor modificarProveedor = new Vistas.Proveedor.modificarProveedor();
            modificarProveedor.Show();
        }

        private void btnEliminarProveedor_Click(object sender, RoutedEventArgs e)
        {
            Vistas.Proveedor.eliminarProveedor eliminarProveedor = new Vistas.Proveedor.eliminarProveedor();
            eliminarProveedor.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }
    }
}
