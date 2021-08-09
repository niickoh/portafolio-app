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
    /// Lógica de interacción para eliminarProducto.xaml
    /// </summary>
    public partial class eliminarProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
            cmbEliminarIDProducto.ItemsSource = negocio_Producto.listar_producto().DefaultView;
            cmbEliminarIDProducto.DisplayMemberPath = "ID";
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

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar el Tipo de Producto?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
                    negocio_Producto.eliminar_producto(int.Parse(cmbEliminarIDProducto.Text));
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Producto eliminado");
                    db.ConexionBD().Open();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Producto NO eliminado");
                    this.Close();
                }


            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarIDProducto.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes ingresar un ID para eliminar");
                }
            }
        }
    }
}
