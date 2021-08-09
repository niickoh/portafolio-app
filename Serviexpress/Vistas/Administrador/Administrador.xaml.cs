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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Serviexpress.Vistas.Administrador
{
    /// <summary>
    /// Lógica de interacción para Administrador.xaml
    /// </summary>
    public partial class Administrador : MetroWindow
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void tlUsuarios_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tlOrdenes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tlProductos_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tlReportes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tlAdministracion_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Vistas.Administrador.Administracion administracion = new Vistas.Administrador.Administracion();
            administracion.ShowDialog();
        }

        private async void Tile_Click(object sender, RoutedEventArgs e)
        {
            MessageDialogResult cerrar_sesion = await this.ShowMessageAsync("","¿Deseas cerrar sesión?", MessageDialogStyle.AffirmativeAndNegative);
            if (cerrar_sesion.Equals(MessageDialogResult.Affirmative))
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }else if (cerrar_sesion.Equals(MessageDialogResult.Negative))
            {
                this.Show();
            }
        }
    }
}
