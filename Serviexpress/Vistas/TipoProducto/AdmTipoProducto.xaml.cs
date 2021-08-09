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

namespace Serviexpress.Vistas.TipoProducto
{
    /// <summary>
    /// Lógica de interacción para AdmTipoProducto.xaml
    /// </summary>
    public partial class AdmTipoProducto : MetroWindow
    {
        public AdmTipoProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoProducto negocio_TipoProducto = new Negocio_Serviexpress.Negocio_tipoProducto();
            dgTipoProducto.ItemsSource = negocio_TipoProducto.listar_tipo_producto().DefaultView;
        }

        private void btnBuscarTipoProducto_Click(object sender, RoutedEventArgs e)
        {
            if (txtBuscarTipoProducto.Text != "")
            {
                Negocio_Serviexpress.Negocio_tipoProducto negocio_TipoProducto = new Negocio_Serviexpress.Negocio_tipoProducto();
                dgTipoProducto.ItemsSource = negocio_TipoProducto.buscar_tipo_producto(txtBuscarTipoProducto.Text).DefaultView;
            }
            else
            {
                Negocio_Serviexpress.Negocio_tipoProducto negocio_TipoProducto = new Negocio_Serviexpress.Negocio_tipoProducto();
                dgTipoProducto.ItemsSource = negocio_TipoProducto.listar_tipo_producto().DefaultView;
            }
            
        }

        private void btnAgregarTipoProducto_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoProducto.agregarTipoProducto agregarTipoProducto = new Vistas.TipoProducto.agregarTipoProducto();
            agregarTipoProducto.Show();
        }

        private void btnEditarTipoProducto_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoProducto.modificarTipoProducto modificarTipoProducto = new Vistas.TipoProducto.modificarTipoProducto();
            modificarTipoProducto.Show();
        }

        private void btnEliminarTipoProducto_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoProducto.eliminarTipoProducto eliminarTipoProducto = new Vistas.TipoProducto.eliminarTipoProducto();
            eliminarTipoProducto.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }
    }
}
