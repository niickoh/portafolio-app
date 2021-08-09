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

namespace Serviexpress.Vistas.Proveedor
{
    /// <summary>
    /// Lógica de interacción para eliminarProveedor.xaml
    /// </summary>
    public partial class eliminarProveedor : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();    
        public eliminarProveedor()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Proveedor negocio_Proveedor = new Negocio_Serviexpress.Negocio_Proveedor();
            cmbEliminarIDProveedor.ItemsSource = negocio_Proveedor.listar_proveedor().DefaultView;
            cmbEliminarIDProveedor.DisplayMemberPath = "ID";
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

        private async void btnEliminarProveedor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar el proveedor seleccionado?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Proveedor negocio_Proveedor = new Negocio_Serviexpress.Negocio_Proveedor();
                    negocio_Proveedor.eliminar_proveedor(int.Parse(cmbEliminarIDProveedor.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Proveedor eliminado correctamente");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Proveedor NO eliminado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarIDProveedor.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes seleccionar un ID para eliminar");
                }
            }
        }
    }
}
