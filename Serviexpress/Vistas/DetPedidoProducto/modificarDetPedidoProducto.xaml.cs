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
    /// Lógica de interacción para modificarDetPedidoProducto.xaml
    /// </summary>
    public partial class modificarDetPedidoProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarDetPedidoProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
            cmbEditarIDOrdenCompra.ItemsSource = negocio_OrdenDeCompra.listar_orden_de_compra().DefaultView;
            cmbEditarIDOrdenCompra.DisplayMemberPath = "ID";
            Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
            cmbEditarIDProducto.ItemsSource = negocio_Producto.listar_producto().DefaultView;
            cmbEditarIDProducto.DisplayMemberPath = "ID";
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

        private async void btnEditarDetPedidoProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar el detalle de pedido de producto?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_DetPedidoProducto negocio_DetPedidoProducto = new Negocio_Serviexpress.Negocio_DetPedidoProducto();
                    negocio_DetPedidoProducto.editar_det_pedido_producto(int.Parse(txtEditarIDDetPedidoProducto.Text), int.Parse(txtEditarCantidad.Text), 
                                                                         int.Parse(cmbEditarIDOrdenCompra.Text), int.Parse(cmbEditarIDProducto.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Detalle de Pedido editado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Detalle de Pedido editado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtEditarIDDetPedidoProducto.Text) || string.IsNullOrEmpty(txtEditarCantidad.Text) || string.IsNullOrEmpty(cmbEditarIDOrdenCompra.Text) ||
                    string.IsNullOrEmpty(cmbEditarIDProducto.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }
            }
        }
    }
}
