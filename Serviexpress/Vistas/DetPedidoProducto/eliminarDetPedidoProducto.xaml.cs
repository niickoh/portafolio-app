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

namespace Serviexpress.Vistas.DetPedidoProducto
{
    /// <summary>
    /// Lógica de interacción para eliminarDetPedidoProducto.xaml
    /// </summary>
    public partial class eliminarDetPedidoProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarDetPedidoProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_DetPedidoProducto negocio_DetPedidoProducto = new Negocio_Serviexpress.Negocio_DetPedidoProducto();
            cmbEliminarIDPedidoProducto.ItemsSource = negocio_DetPedidoProducto.listar_det_pedido_producto().DefaultView;
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

        private async void btnEliminarPedidoProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar el detalle de pedido seleccionado?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_DetPedidoProducto negocio_DetPedidoProducto = new Negocio_Serviexpress.Negocio_DetPedidoProducto();
                    negocio_DetPedidoProducto.eliminar_det_pedido_producto(int.Parse(cmbEliminarIDPedidoProducto.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Detalle de pedido de producto eliminado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Detalle de pedido de producto NO eliminado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrWhiteSpace(cmbEliminarIDPedidoProducto.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes seleccionar un ID para eliminar");
                }
            }
        }
    }
}
