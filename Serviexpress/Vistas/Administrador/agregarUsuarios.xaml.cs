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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Data.OracleClient;
using System.Data;
using System.Configuration;

namespace Serviexpress.Vistas.Administrador
{
    /// <summary>
    /// Lógica de interacción para agregarUsuarios.xaml
    /// </summary>
    public partial class agregarUsuarios : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public agregarUsuarios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoUsuario tipUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
            cmbTipoUsuario.ItemsSource = tipUsuario.listar_tipo_usuario_paquete().DefaultView;
            cmbTipoUsuario.DisplayMemberPath = "DESCRIPCION";
            cmbTipoUsuario.SelectedValue = "ID";
        }

        
        private async void btnAgregar_Click_1(object sender, RoutedEventArgs e)
        {
            

            try 
            {               
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("Confirmación", "¿Está seguro de agregar al usuario?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Usuario negocio_Usuario = new Negocio_Serviexpress.Negocio_Usuario();
                    db.ConexionBD().Open();
                    negocio_Usuario.agregar_usuarios(cmbTipoUsuario.SelectedIndex + 1, txtUsuario.Text, txtContrasena.Text,
                                                      txtCorreo.Text, txtPnombre.Text, txtSnombre.Text, txtApaterno.Text, txtAmaterno.Text,
                                                      Convert.ToInt32(txtRut.Text), txtDV.Text, dpFechaNac.Text);
                    await this.ShowMessageAsync("Hecho", "Usuario Agregado");
                    this.Close();
                }else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("Cancelado", "Usuario no agregado");
                    this.Close();
                }

                db.ConexionBD().Close();   

            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbTipoUsuario.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text) ||
                    string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtPnombre.Text) || string.IsNullOrEmpty(txtSnombre.Text) ||
                    string.IsNullOrEmpty(txtApaterno.Text) || string.IsNullOrEmpty(txtAmaterno.Text) || string.IsNullOrEmpty(txtRut.Text) ||
                    string.IsNullOrEmpty(txtDV.Text) || string.IsNullOrEmpty(dpFechaNac.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para agregar");
                }
                
            }
            
        }

        private async void btnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            MessageDialogResult mensaje_cancelar = await this.ShowMessageAsync("¡Cuidado!", "¿Deseas salir?", MessageDialogStyle.AffirmativeAndNegative);
            if (mensaje_cancelar.Equals(MessageDialogResult.Affirmative))
            {
                this.Close();
            }
            else if (mensaje_cancelar.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
            
        }
    }
}
