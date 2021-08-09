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
    /// Lógica de interacción para eliminarUsuarios.xaml
    /// </summary>
    public partial class eliminarUsuarios : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarUsuarios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Usuario negocio_Usuario = new Negocio_Serviexpress.Negocio_Usuario();
            cmbID.ItemsSource = negocio_Usuario.listar_usuarios().DefaultView;
            cmbID.DisplayMemberPath = "ID";
            
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Negocio_Serviexpress.Negocio_Usuario negocio_Usuario = new Negocio_Serviexpress.Negocio_Usuario();
                negocio_Usuario.eliminar_usuarios(int.Parse(cmbID.Text));

                db.ConexionBD().Open();
                await this.ShowMessageAsync("¡Hecho!", "Usuario Eliminado");
                db.ConexionBD().Close();
                this.Close();
                
            }
            catch (Exception)
            {
                
                if (string.IsNullOrEmpty(cmbID.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "¡Necesita seleccionar id para eliminar!");
                }
                
            }
            

        }

        private async void btnCancelar_Click(object sender, RoutedEventArgs e)
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
    }
}
