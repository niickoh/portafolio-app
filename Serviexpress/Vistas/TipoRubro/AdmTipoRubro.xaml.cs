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
    /// Lógica de interacción para AdmTipoRubro.xaml
    /// </summary>
    public partial class AdmTipoRubro : MetroWindow
    {
        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        public AdmTipoRubro()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_tipoRubro negocio_TipoRubro = new Negocio_Serviexpress.Negocio_tipoRubro();
            dgTipoRubro.ItemsSource = negocio_TipoRubro.listar_tipo_rubro().DefaultView;
        }

        private async void btnAgregarTipoRubro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialogResult mensaje_agregar = await this.ShowMessageAsync("¡Confirmación!", "¿Está seguro de agregar un nuevo tipo de rubro?", MessageDialogStyle.AffirmativeAndNegative);
                if (mensaje_agregar.Equals(MessageDialogResult.Affirmative))
                {
                    Negocio_Serviexpress.Negocio_tipoRubro negocio_TipoRubro = new Negocio_Serviexpress.Negocio_tipoRubro();
                    negocio_TipoRubro.agregar_tipo_rubro(txtBuscarTipoRubro.Text);
                    db.ConexionBD().Open();
                    await this.ShowMessageAsync("¡Hecho!", "Tipo de rubro agregado");
                    db.ConexionBD().Close();
                    
                }
                else if (mensaje_agregar.Equals(MessageDialogResult.Negative))
                {
                    await this.ShowMessageAsync("¡Cancelado!", "Tipo de rubro NO agregado");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtBuscarTipoRubro.Text))
                {
                    await this.ShowMessageAsync("¡Advertencia!", "Necesitas agregar una descripción de tipo de rubro a agregar");
                }
            }
            
        }

        private void btnEditarTipoRubro_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoRubro.modificarTipoRubro modificarTipoRubro = new Vistas.TipoRubro.modificarTipoRubro();
            modificarTipoRubro.Show();
        }

        private void btnEliminarTipoRubro_Click(object sender, RoutedEventArgs e)
        {
            Vistas.TipoRubro.eliminarTipoRubro eliminarTipoRubro = new Vistas.TipoRubro.eliminarTipoRubro();
            eliminarTipoRubro.Show();
        }

        private void btnBuscarTipoRubro_Click(object sender, RoutedEventArgs e)
        {
            Negocio_Serviexpress.Negocio_tipoRubro negocio_TipoRubro = new Negocio_Serviexpress.Negocio_tipoRubro();
            dgTipoRubro.ItemsSource = negocio_TipoRubro.listar_tipo_rubro().DefaultView;
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.Show();
        }
    }
}
