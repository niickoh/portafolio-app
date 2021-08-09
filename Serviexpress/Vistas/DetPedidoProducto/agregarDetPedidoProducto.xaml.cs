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
    /// Lógica de interacción para agregarDetPedidoProducto.xaml
    /// </summary>
    public partial class agregarDetPedidoProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public agregarDetPedidoProducto()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_OrdenDeCompra negocio_OrdenDeCompra = new Negocio_Serviexpress.Negocio_OrdenDeCompra();
            cmbIDOrdenCompra.ItemsSource = negocio_OrdenDeCompra.listar_orden_de_compra().DefaultView;
            cmbIDOrdenCompra.DisplayMemberPath = "ID";
            Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
            cmbIDProducto.ItemsSource = negocio_Producto.listar_producto().DefaultView;
            cmbIDProducto.DisplayMemberPath = "ID";
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

        private async void btnAgregarDetPedidoProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de agregar el detalle del producto?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_DetPedidoProducto negocio_DetPedidoProducto = new Negocio_Serviexpress.Negocio_DetPedidoProducto();
                    negocio_DetPedidoProducto.agregar_det_pedido_producto(int.Parse(txtAgregarCantidad.Text), int.Parse(cmbIDOrdenCompra.Text), int.Parse(cmbIDProducto.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Detalle de Producto agregado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Detalle de Producto NO agregado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtAgregarCantidad.Text) || string.IsNullOrEmpty(cmbIDOrdenCompra.Text) || string.IsNullOrEmpty(cmbIDProducto.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para agregar");
                }
            }
        }
    }
}
