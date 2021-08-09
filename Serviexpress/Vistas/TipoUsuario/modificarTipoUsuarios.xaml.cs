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

namespace Serviexpress.Vistas.TipoUsuario
{
    /// <summary>
    /// Lógica de interacción para modificarTipoUsuarios.xaml
    /// </summary>
    public partial class modificarTipoUsuarios : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarTipoUsuarios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoUsuario negocio_TipoUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
            cmbModID.ItemsSource = negocio_TipoUsuario.listar_tipo_usuario_paquete().DefaultView;
            cmbModID.DisplayMemberPath = "ID";
        }

        private async void btnModSalir_Click(object sender, RoutedEventArgs e)
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

        private async void btnModEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Está seguro de editar el tipo de usuario indicado?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoUsuario negocio_TipoUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
                    negocio_TipoUsuario.modificar_tipo_usuario(int.Parse(cmbModID.Text), txtModDescripcion.Text);
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Tipo Usuario editado");
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("Cancelado", "Tipo Usuario no editado");
                    this.Show();
                }

            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbModID.Text) || string.IsNullOrEmpty(txtModDescripcion.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }

            }
        }
    }
}
