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
    /// Lógica de interacción para modificarTipoProducto.xaml
    /// </summary>
    public partial class modificarTipoProducto : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarTipoProducto()
        {
            InitializeComponent();
        }

        private async void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageDialogResult mensaje_salir = await this.ShowMessageAsync("¡Cuidado!", "¿Deseas salir?", MessageDialogStyle.AffirmativeAndNegative);
            if (mensaje_salir.Equals(MessageDialogResult.Affirmative))
            {
                this.Close();
            }else if (mensaje_salir.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
        }

        private async void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar el Tipo de Producto?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoProducto negocio_TipoProducto = new Negocio_Serviexpress.Negocio_tipoProducto();
                    negocio_TipoProducto.editar_tipo_producto(int.Parse(txtModID.Text), txtModDescripcionTP.Text, int.Parse(txtModPrecioCompraTP.Text),
                                                              int.Parse(txtModPrecioVentaTP.Text), int.Parse(txtModStockCriticoTP.Text));
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Tipo de Producto editado");
                    db.ConexionBD().Open();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Tipo de Producto NO editado");
                    this.Close();
                }
                

            }catch (Exception)
            {
                if (string.IsNullOrEmpty(txtModID.Text) || string.IsNullOrEmpty(txtModDescripcionTP.Text) || string.IsNullOrEmpty(txtModPrecioCompraTP.Text) ||
                    string.IsNullOrEmpty(txtModPrecioVentaTP.Text) || string.IsNullOrEmpty(txtModStockCriticoTP.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para modificar");
                }
            }
        }
    }
}
