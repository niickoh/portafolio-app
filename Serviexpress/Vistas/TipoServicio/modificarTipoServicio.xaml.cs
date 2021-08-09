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

namespace Serviexpress.Vistas.TipoServicio
{
    /// <summary>
    /// Lógica de interacción para modificarTipoServicio.xaml
    /// </summary>
    public partial class modificarTipoServicio : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarTipoServicio()
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

        private async void btnModTS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar el tipo de servicio?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoServicio negocio_TipoServicio = new Negocio_Serviexpress.Negocio_tipoServicio();
                    negocio_TipoServicio.editar_tipo_servicio(int.Parse(txtModIDTS.Text), txtModDescripcionTS.Text, int.Parse(txtModPrecioTS.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Tipo de servicio editado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Tipo de servicio NO editado");
                    this.Show();
                }

            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtModIDTS.Text) || string.IsNullOrEmpty(txtModDescripcionTS.Text) || string.IsNullOrEmpty(txtModPrecioTS.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }
            }
        }
    }
}
