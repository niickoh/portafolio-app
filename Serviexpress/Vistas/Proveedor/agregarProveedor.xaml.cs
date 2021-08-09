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
    /// Lógica de interacción para agregarProveedor.xaml
    /// </summary>
    public partial class agregarProveedor : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public agregarProveedor()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoRubro negocio_TipoRubro = new Negocio_Serviexpress.Negocio_tipoRubro();
            cmbTipoRubroProveedor.ItemsSource = negocio_TipoRubro.listar_tipo_rubro().DefaultView;
            cmbTipoRubroProveedor.DisplayMemberPath = "DESCRIPCION";
            cmbTipoRubroProveedor.SelectedValue = "ID";
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

        private async void btnAgregarProveedor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de agregar un nuevo proveedor?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Proveedor negocio_Proveedor = new Negocio_Serviexpress.Negocio_Proveedor();
                    negocio_Proveedor.agregar_proveedor(int.Parse(cmbTipoRubroProveedor.Text), txtNombreProveedor.Text, int.Parse(txtTelefonoProveedor.Text), txtEmailProveedor.Text);

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Proveedor agregado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Proveedor NO agregado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbTipoRubroProveedor.Text) || string.IsNullOrEmpty(txtNombreProveedor.Text) || string.IsNullOrEmpty(txtTelefonoProveedor.Text) ||
                    string.IsNullOrEmpty(txtEmailProveedor.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para agregar un nuevo proveedor");
                }
            }
        }
    }
}
