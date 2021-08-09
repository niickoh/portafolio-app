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
    /// Lógica de interacción para agregarProducto.xaml
    /// </summary>
    public partial class agregarProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public agregarProducto()
        {
            InitializeComponent();
        }

        private async void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageDialogResult mensaje_salir = await this.ShowMessageAsync("¡Cuidado!", "¿Desea salir?", MessageDialogStyle.AffirmativeAndNegative);
            if (mensaje_salir.Equals(MessageDialogResult.Affirmative))
            {
                this.Close();
            }else if (mensaje_salir.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
        }

        private async void btnAgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Confirmación!", "¿Está seguro de agregar el producto?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Producto negocio_Producto = new Negocio_Serviexpress.Negocio_Producto();
                    negocio_Producto.agregar_producto(int.Parse(txtProductoStock.Text), dpFechaVencimiento.SelectedDate.Value, 
                                                      txtProductoDescripcion.Text, int.Parse(txtTipoProducto.Text));
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Producto Agregado");
                    this.Close();
                }
                else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Producto NO Agregado");
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtProductoStock.Text) || string.IsNullOrEmpty(dpFechaVencimiento.Text) || string.IsNullOrEmpty(txtProductoDescripcion.Text) || string.IsNullOrEmpty(txtTipoProducto.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para agregar producto");
                }
                
            }
        }
    }
}
