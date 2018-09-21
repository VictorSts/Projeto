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
    /// Interação lógica para UserControlAutomovel.xam
    /// </summary>
    public partial class UserControlAutomovel : UserControl
    {
        public UserControlAutomovel()
        {
            InitializeComponent();
        }

        private void btnGolf_Click(object sender, RoutedEventArgs e)
        {
            Contatos janela = new Contatos();
            janela.Show();
        }

        private void btnRanger_Click(object sender, RoutedEventArgs e)
        {
            Contatos janela = new Contatos();
            janela.Show();
        }

        private void btnOnix_Click(object sender, RoutedEventArgs e)
        {
            Contatos janela = new Contatos();
            janela.Show();
        }
    }
}
