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
    /// Lógica de interacción para AdmTipoUsuarios.xaml
    /// </summary>
    public partial class AdmTipoUsuarios : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public AdmTipoUsuarios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoUsuario negocio_TipoUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
            dgTipoUsuarios.ItemsSource = negocio_TipoUsuario.listar_tipo_usuario_paquete().DefaultView;
        }

        private async void btnAgregarTipoUsuario_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Advertencia!", "¿Estás seguro de agregar nuevo tipo de usuario?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoUsuario negocio_TipoUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
                    negocio_TipoUsuario.agregar_tipo_usuarios(txtBuscarTipoUsuario.Text);
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Nuevo tipo de usuario agregado");
                }else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Nuevo tipo de usuario NO agregado");
                }
                db.ConexionBD().Close();
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtBuscarTipoUsuario.Text))
                {
                    await this.ShowMessageAsync("¡Error!", "El campo no puede estar vacío");
                }
                
            }
        }

        private void btnModificarTipoUsuario_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoUsuario.modificarTipoUsuarios modificarTipoUsuarios = new Vistas.TipoUsuario.modificarTipoUsuarios();
            modificarTipoUsuarios.Show();
        }

        private void btnEliminarTipoUsuario_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoUsuario.eliminarTipoUsuarios eliminarTipoUsuarios = new Vistas.TipoUsuario.eliminarTipoUsuarios();
            eliminarTipoUsuarios.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }

        private void btnBuscarTipoUsuario_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_tipoUsuario negocio_TipoUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
            dgTipoUsuarios.ItemsSource = negocio_TipoUsuario.buscar_tipo_usuario(txtBuscarTipoUsuario.Text).DefaultView;
        }
    }
}
