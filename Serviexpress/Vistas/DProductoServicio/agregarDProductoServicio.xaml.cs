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
    /// Lógica de interacción para agregarDProductoServicio.xaml
    /// </summary>
    public partial class agregarDProductoServicio : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public agregarDProductoServicio()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Servicios negocio_Servicios = new Negocio_Serviexpress.Negocio_Servicios();
            cmbAgregarServicioID.ItemsSource = negocio_Servicios.listar_servicios().DefaultView;
            cmbAgregarServicioID.DisplayMemberPath = "ID";
            Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
            cmbAgregarProductoID.ItemsSource = negocio_Producto.listar_producto().DefaultView;
            cmbAgregarProductoID.DisplayMemberPath = "ID";

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

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de agregar el detalle de producto-servicio?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_DProductoServicio negocio_DProductoServicio = new Negocio_Serviexpress.Negocio_DProductoServicio();
                    negocio_DProductoServicio.agregar_d_producto_servicio(int.Parse(txtAgregarCantidad.Text), int.Parse(cmbAgregarServicioID.Text), 
                                                                          int.Parse(cmbAgregarProductoID.Text));
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Detalle de producto-servicio agregado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Detalle de producto-servicio NO agregado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtAgregarCantidad.Text) || string.IsNullOrEmpty(cmbAgregarServicioID.Text) || string.IsNullOrEmpty(cmbAgregarProductoID.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los datos para agregar");
                }
            }
        }
    }
}
