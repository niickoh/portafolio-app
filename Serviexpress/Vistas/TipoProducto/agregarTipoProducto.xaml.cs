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

namespace Serviexpress.Vistas.TipoProducto
{
    /// <summary>
    /// Lógica de interacción para agregarTipoProducto.xaml
    /// </summary>
    public partial class agregarTipoProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public agregarTipoProducto()
        {
            InitializeComponent();
        }

        private async void btnSalirTipoProducto_Click(object sender, RoutedEventArgs e)
        {
            MessageDialogResult mensaje_salir = await this.ShowMessageAsync("¡Cuidado!", "¿Deseas salir?", MessageDialogStyle.AffirmativeAndNegative);
            if (mensaje_salir.Equals(MessageDialogResult.Affirmative))
            {
                this.Close();
            }
            if (mensaje_salir.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
        }

        private async void btnAgregarTipoProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de agregar un nuevo Tipo de Producto?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoProducto negocio_TipoProducto = new Negocio_Serviexpress.Negocio_tipoProducto();
                    negocio_TipoProducto.agregar_tipo_producto(txtDescripcionTipoProducto.Text, int.Parse(txtPrecioCompraTipoProducto.Text), int.Parse(txtPrecioVentaTipoProducto.Text),
                                                               int.Parse(txtStockCriticoTipoProducto.Text));
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Nuevo Tipo de Producto agregado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Nuevo Tipo de Producto NO agregado");
                    this.Close();
                }
                

            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtDescripcionTipoProducto.Text) || string.IsNullOrEmpty(txtPrecioCompraTipoProducto.Text) ||
                    string.IsNullOrEmpty(txtPrecioVentaTipoProducto.Text) || string.IsNullOrEmpty(txtStockCriticoTipoProducto.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para agregar un nuevo tipo de producto");
                }
            }
        }
    }
}
