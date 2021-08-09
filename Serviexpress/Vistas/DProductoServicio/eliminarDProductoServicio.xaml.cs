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
    /// Lógica de interacción para eliminarDProductoServicio.xaml
    /// </summary>
    public partial class eliminarDProductoServicio : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarDProductoServicio()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_DProductoServicio negocio_DProductoServicio= new Negocio_Serviexpress.Negocio_DProductoServicio();
            cmbEliminarIDProductoServicio.ItemsSource = negocio_DProductoServicio.listar_d_producto_servicio().DefaultView;
            cmbEliminarIDProductoServicio.DisplayMemberPath = "ID";
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

        private async void btnEliminarProductoServicio_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar el ID seleccionado?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_DProductoServicio negocio_DProductoServicio = new Negocio_Serviexpress.Negocio_DProductoServicio();
                    negocio_DProductoServicio.eliminar_d_producto_servicio(int.Parse(cmbEliminarIDProductoServicio.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Detalle de producto-servicio editado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Detalle de producto-servicio NO editado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarIDProductoServicio.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes seleccionar un ID para eliminar");
                }
            }
        }
    }
}
