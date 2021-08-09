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
    /// Lógica de interacción para eliminarTipoUsuarios.xaml
    /// </summary>
    public partial class eliminarTipoUsuarios : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarTipoUsuarios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoUsuario negocio_TipoUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
            cmbIDTipoUsuario.ItemsSource = negocio_TipoUsuario.listar_tipo_usuario_paquete().DefaultView;
            cmbIDTipoUsuario.DisplayMemberPath = "ID";
        }

        private async void btnCancelarTipoUsuario_Click(object sender, RoutedEventArgs e)
        {
            MessageDialogResult mensaje_cancelar = await this.ShowMessageAsync("¡Cuidado!", "¿Deseas salir?", MessageDialogStyle.AffirmativeAndNegative);
            if (mensaje_cancelar.Equals(MessageDialogResult.Affirmative))
            {
                this.Close();
            }else if (mensaje_cancelar.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
        }

        private void btnEliminarTipoUsuario_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Negocio_Serviexpress.Negocio_tipoUsuario negocio_TipoUsuario = new Negocio_Serviexpress.Negocio_tipoUsuario();
                negocio_TipoUsuario.eliminar_tipo_usuario(int.Parse(cmbIDTipoUsuario.Text));
                db.ConexionBD().Open();
                MessageBox.Show("Tipo de Usuario eliminado");
                db.ConexionBD().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
