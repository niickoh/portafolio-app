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
    /// Lógica de interacción para modificarProveedor.xaml
    /// </summary>
    public partial class modificarProveedor : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarProveedor()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoRubro negocio_TipoRubro = new Negocio_Serviexpress.Negocio_tipoRubro();
            cmbModTipoRubroProveedor.ItemsSource = negocio_TipoRubro.listar_tipo_rubro().DefaultView;
            cmbModTipoRubroProveedor.DisplayMemberPath = "DESCRIPCION";
            cmbModTipoRubroProveedor.SelectedValue = "ID";
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

        private async void btnEditarProveedor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar el proveedor?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Proveedor negocio_Proveedor = new Negocio_Serviexpress.Negocio_Proveedor();
                    negocio_Proveedor.modificar_proveedor(int.Parse(txtIDProveedor.Text), int.Parse(cmbModTipoRubroProveedor.Text), txtModNombreProveedor.Text,
                                                          int.Parse(txtModTelefonoProveedor.Text), txtModEmailProveedor.Text);

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Proveedor editado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Proveedor NO editado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtIDProveedor.Text) || string.IsNullOrEmpty(cmbModTipoRubroProveedor.Text) || string.IsNullOrEmpty(txtModNombreProveedor.Text) ||
                    string.IsNullOrEmpty(txtModTelefonoProveedor.Text) || string.IsNullOrEmpty(txtModEmailProveedor.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }
            }
        }
    }
}
