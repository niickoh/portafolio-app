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

namespace Serviexpress.Vistas.TipoRubro
{
    /// <summary>
    /// Lógica de interacción para eliminarTipoRubro.xaml
    /// </summary>
    public partial class eliminarTipoRubro : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarTipoRubro()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoRubro negocio_TipoRubro = new Negocio_Serviexpress.Negocio_tipoRubro();
            cmbEliminarID.ItemsSource = negocio_TipoRubro.listar_tipo_rubro().DefaultView;
            cmbEliminarID.DisplayMemberPath = "ID";
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

        private async void btnEliminarIDTR_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar el Tipo de Rubro?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoRubro negocio_TipoRubro = new Negocio_Serviexpress.Negocio_tipoRubro();
                    negocio_TipoRubro.eliminar_tipo_rubro(int.Parse(cmbEliminarID.Text));
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Tipo de rubro eliminado");
                    db.ConexionBD().Open();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Tipo de Rubro NO eliminado");
                    this.Close();
                }


            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarID.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes ingresar un ID para eliminar");
                }
            }
        }
    }
}
