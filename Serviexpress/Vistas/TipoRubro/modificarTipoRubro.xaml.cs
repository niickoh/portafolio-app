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
    /// Lógica de interacción para modificarTipoRubro.xaml
    /// </summary>
    public partial class modificarTipoRubro : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarTipoRubro()
        {
            InitializeComponent();
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

        private async void CONFIRMAR__Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar el Tipo de Rubro?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoRubro negocio_TipoRubro = new Negocio_Serviexpress.Negocio_tipoRubro();
                    negocio_TipoRubro.editar_tipo_rubro(int.Parse(txtModID.Text), txtModDescripcion.Text);
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Tipo de Rubro editado");
                    db.ConexionBD().Open();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Tipo de Rubro NO editado");
                    this.Close();
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtModID.Text) || string.IsNullOrEmpty(txtModDescripcion.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para modificar");
                }
            }
        }
    }
}
