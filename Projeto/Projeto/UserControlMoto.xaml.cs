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

namespace Projeto
{
    /// <summary>
    /// Interação lógica para UserControlMoto.xam
    /// </summary>
    public partial class UserControlMoto : UserControl
    {
        public UserControlMoto()
        {
            InitializeComponent();
        }

        private void btnKawasaki_Click(object sender, RoutedEventArgs e)
        {
            Contatos janela = new Contatos();
            janela.Show();
        }

        private void btnBMW_Click(object sender, RoutedEventArgs e)
        {
            Contatos janela = new Contatos();
            janela.Show();
        }

        private void btnSuzuki_Click(object sender, RoutedEventArgs e)
        {
            Contatos janela = new Contatos();
            janela.Show();
        }
    }
}
