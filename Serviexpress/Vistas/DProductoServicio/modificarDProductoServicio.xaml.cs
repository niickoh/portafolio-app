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
    /// Lógica de interacción para modificarDProductoServicio.xaml
    /// </summary>
    public partial class modificarDProductoServicio : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarDProductoServicio()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Servicios negocio_Servicios = new Negocio_Serviexpress.Negocio_Servicios();
            cmbEditarServicioID.ItemsSource = negocio_Servicios.listar_servicios().DefaultView;
            cmbEditarServicioID.DisplayMemberPath = "ID";
            Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
            cmbEditarProductoID.ItemsSource = negocio_Producto.listar_producto().DefaultView;
            cmbEditarProductoID.DisplayMemberPath = "ID";
        }

        private async void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageDialogResult mensaje_salir = await this.ShowMessageAsync("¡Cuidado!", "¿Deseas salir?", MessageDialogStyle.AffirmativeAndNegative);
            if (mensaje_salir.Equals(MessageDialogResult.Affirmative))
            {
                this.Close();
            }
            else if (mensaje_salir.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
        }

        private async void btnEditarDProductoPedido_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar el detalle de producto-servicio?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_DProductoServicio negocio_DProductoServicio = new Negocio_Serviexpress.Negocio_DProductoServicio();
                    negocio_DProductoServicio.editar_d_producto_servicio(int.Parse(txtEditarID.Text), int.Parse(txtEditarCantidad.Text), int.Parse(cmbEditarServicioID.Text),
                                                                         int.Parse(cmbEditarProductoID.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Detalle de producto-servicio editado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Detalle de producto-servicio NO editado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtEditarID.Text) || string.IsNullOrEmpty(txtEditarCantidad.Text) || string.IsNullOrEmpty(cmbEditarServicioID.Text) ||
                    string.IsNullOrEmpty(cmbEditarProductoID.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }
            }
        }
    }
}
