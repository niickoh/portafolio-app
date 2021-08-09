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

namespace Serviexpress.Vistas.ReservaHora
{
    /// <summary>
    /// Lógica de interacción para AdmReservaHora.xaml
    /// </summary>
    public partial class AdmReservaHora : Window
    {
        public AdmReservaHora()
        {
            InitializeComponent();
            Negocio_Serviexpress.Negocio_ReservaHora negocio_ReservaHora = new Negocio_Serviexpress.Negocio_ReservaHora();
            dgReservaHoras.ItemsSource = negocio_ReservaHora.listar().DefaultView;

        }
    }
}
