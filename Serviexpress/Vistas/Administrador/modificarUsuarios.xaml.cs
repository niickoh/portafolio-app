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
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Serviexpress.Vistas.Administrador
{
    /// <summary>
    /// Lógica de interacción para modificarUsuarios.xaml
    /// </summary>
    public partial class modificarUsuarios : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarUsuarios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoUsuario negocio_TipoUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
            cmbModTipo.ItemsSource = negocio_TipoUsuario.listar_tipo_usuario_paquete().DefaultView;
            cmbModTipo.DisplayMemberPath = "DESCRIPCION";
            cmbModTipo.SelectedValue = "ID";

            
            
        }

        private async void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Negocio_Serviexpress.Negocio_Usuario negocio_Usuario = new Negocio_Serviexpress.Negocio_Usuario();
                negocio_Usuario.modificar_usuarios(Convert.ToInt32(txtModID.Text), cmbModTipo.SelectedIndex + 1, txtModUsuario.Text,
                                                   txtModContrasena.Text, txtModCorreo.Text, txtModPnombre.Text, txtModSnombre.Text,
                                                   txtModApaterno.Text, txtModAmaterno.Text, Convert.ToInt32(txtModRut.Text),
                                                   txtModDV.Text, dpModFechaNac.Text);
                db.ConexionBD().Open();
                MessageDialogResult mensaje_modificar = await this.ShowMessageAsync("Confirmación", "¿Está seguro de modificar el usuario?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_modificar.Equals(MessageDialogResult.Affirmative))
                {
                    await this.ShowMessageAsync("Hecho", "Usuario Modificado");
                }
                else if (mensaje_modificar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("Cancelado", "Usuario no modificado");
                }

            } 
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtModID.Text) || string.IsNullOrEmpty(cmbModTipo.Text) || string.IsNullOrEmpty(txtModUsuario.Text) ||
                    string.IsNullOrEmpty(txtModContrasena.Text) || string.IsNullOrEmpty(txtModCorreo.Text) || string.IsNullOrEmpty(txtModPnombre.Text) ||
                    string.IsNullOrEmpty(txtModSnombre.Text) || string.IsNullOrEmpty(txtModApaterno.Text) || string.IsNullOrEmpty(txtModAmaterno.Text) ||
                    string.IsNullOrEmpty(txtModRut.Text) || string.IsNullOrEmpty(txtModDV.Text) || string.IsNullOrEmpty(dpModFechaNac.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para modificar");
                }
            }
        }

        private async void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageDialogResult mensaje_cancelar = await this.ShowMessageAsync("¡Cuidado!", "¿Deseas salir?", MessageDialogStyle.AffirmativeAndNegative);
            if (mensaje_cancelar.Equals(MessageDialogResult.Affirmative))
            {
                this.Close();
            }else if(mensaje_cancelar.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
        }
    }
}
