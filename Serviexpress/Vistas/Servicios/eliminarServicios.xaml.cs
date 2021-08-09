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
    /// Lógica de interacción para eliminarServicios.xaml
    /// </summary>
    public partial class eliminarServicios : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarServicios()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_Servicios negocio_Servicios = new Negocio_Serviexpress.Negocio_Servicios();
            cmbEliminarIDServicios.ItemsSource = negocio_Servicios.listar_servicios().DefaultView;
            cmbEliminarIDServicios.DisplayMemberPath = "ID";
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

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Estás seguro de eliminar el Servicio seleccionado?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_Servicios negocio_Servicios = new Negocio_Serviexpress.Negocio_Servicios();
                    negocio_Servicios.eliminar_servicios(int.Parse(cmbEliminarIDServicios.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Servicio eliminado");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Servicio NO eliminado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarIDServicios.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes seleccionar un ID para eliminar");
                }
            }
        }
    }
}
