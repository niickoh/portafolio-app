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

namespace Serviexpress.Vistas.Producto
{
    /// <summary>
    /// Lógica de interacción para modificarProducto.xaml
    /// </summary>
    public partial class modificarProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarProducto()
        {
            InitializeComponent();
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

        private async void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar el Producto?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
                    negocio_Producto.editar_producto(int.Parse(txtEditID.Text), int.Parse(txtEditStock.Text), dpEditFechaVencimiento.SelectedDate.Value,
                                                     txtEditDescripcion.Text, int.Parse(txtEditTipoProducto.Text));
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Producto editado");
                    db.ConexionBD().Open();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Producto NO editado");
                    this.Close();
                }


            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtEditID.Text) || string.IsNullOrEmpty(txtEditStock.Text) || string.IsNullOrEmpty(dpEditFechaVencimiento.Text) ||
                    string.IsNullOrEmpty(txtEditDescripcion.Text) || string.IsNullOrEmpty(txtEditTipoProducto.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }
            }
        }
    }
}
