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
    /// Lógica de interacción para eliminarTipoServicio.xaml
    /// </summary>
    public partial class eliminarTipoServicio : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public eliminarTipoServicio()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoServicio negocio_TipoServicio = new Negocio_Serviexpress.Negocio_tipoServicio();
            cmbEliminarTS.ItemsSource = negocio_TipoServicio.listar_tipo_servicio().DefaultView;
            cmbEliminarTS.DisplayMemberPath = "ID";
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

        private async void btnEliminarTS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_eliminar = await this.ShowMessageAsync("¡Confirmación!", "¿Seguro que quieres eliminar el tipo de servicio seleccionado?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_eliminar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoServicio negocio_TipoServicio = new Negocio_Serviexpress.Negocio_tipoServicio();
                    negocio_TipoServicio.eliminar_tipo_servicio(int.Parse(cmbEliminarTS.Text));

                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Tipo de Servicio eliminado correctamente");
                    db.ConexionBD().Close();
                    this.Close();
                }
                else if (mensaje_eliminar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Tipo de Servicio NO eliminado");
                    this.Show();
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(cmbEliminarTS.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Debes seleccionar un ID para eliminar");
                }
            }
        }
    }
}
