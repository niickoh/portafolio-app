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
    /// Lógica de interacción para modificarRecepcionProducto.xaml
    /// </summary>
    public partial class modificarRecepcionProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarRecepcionProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_RecepcionProducto negocio_RecepcionProducto = new Negocio_Serviexpress.Negocio_RecepcionProducto();
            cmbEditarIDOrdenCompra.ItemsSource = negocio_RecepcionProducto.listar_recepcion_producto().DefaultView;
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

        private async void btnEditarRecepcionProductos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar la recepción de productos?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_RecepcionProducto negocio_RecepcionProducto = new Negocio_Serviexpress.Negocio_RecepcionProducto();
                    negocio_RecepcionProducto.editar_recepcion_producto(int.Parse(txtEditarIDRecepcionProductos.Text), dpEditarFecha.Text, int.Parse(txtEditarValidador.Text),
                                                                        txtEditarDescripcion.Text, int.Parse(cmbEditarIDOrdenCompra.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Recepción de Productos editada");
                    db.ConexionBD().Open();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Recepción de Productos NO editada");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtEditarIDRecepcionProductos.Text) || string.IsNullOrEmpty(dpEditarFecha.Text) || string.IsNullOrEmpty(txtEditarValidador.Text) ||
                    string.IsNullOrEmpty(txtEditarDescripcion.Text) || string.IsNullOrEmpty(cmbEditarIDOrdenCompra.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }
            }
        }
    }
}
