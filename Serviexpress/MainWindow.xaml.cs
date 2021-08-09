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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Serviexpress
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Entidades_Serviexpress.Conexion_OracleBD db = new Entidades_Serviexpress.Conexion_OracleBD();
        Negocio_Serviexpress.Negocio_Usuario usu_negocio = new Negocio_Serviexpress.Negocio_Usuario();
        private async void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            
            if(usu_negocio.Logueo(txtUsuario.Text, pbContrasena.Password).Rows.Count == 1)
            {
                if(usu_negocio.Logueo(txtUsuario.Text, pbContrasena.Password).Rows[0][13].ToString() == "Administrador")
                {
                    
                    Vistas.Administrador.Administrador adm = new Vistas.Administrador.Administrador();
                    db.ConexionBD().Close();
                    await this.ShowMessageAsync("Administrador","Seleccione una opción a gestionar");
                    this.Hide();
                    adm.Show();
                }
                else if (usu_negocio.Logueo(txtUsuario.Text, pbContrasena.Password).Rows[0][13].ToString() == "Empleado")
                {
                    Vistas.Empleado.Empleado emp = new Vistas.Empleado.Empleado();
                    db.ConexionBD().Close();
                    await this.ShowMessageAsync("Empleado", "Seleccione una opción a gestionar");
                    emp.Show();
                }
                
            }
            else
            {
                await this.ShowMessageAsync("Error", "Usuario y/o Contraseña incorrectos");
            }

        }
    }
}
