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

namespace Serviexpress.Vistas.Servicios
{
    /// <summary>
    /// Lógica de interacción para modificarServicios.xaml
    /// </summary>
    public partial class modificarServicios : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public modificarServicios()
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

        private async void btnModEditarServicios_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_editar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de editar el servicio?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_editar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Servicios negocio_Servicios = new Negocio_Serviexpress.Negocio_Servicios();
                    negocio_Servicios.editar_servicios(int.Parse(txtModIDServicios.Text), dpModFecha.Text, txtModComentario.Text, int.Parse(txtModValidado.Text),
                                                       int.Parse(txtModIDReserva.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Servicio editado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_editar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Servicio NO editado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtModIDServicios.Text) || string.IsNullOrEmpty(dpModFecha.Text) || string.IsNullOrEmpty(txtModComentario.Text) ||
                    string.IsNullOrEmpty(txtModValidado.Text) || string.IsNullOrEmpty(txtModIDReserva.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes llenar todos los campos para editar");
                }
            }
        }
    }
}
