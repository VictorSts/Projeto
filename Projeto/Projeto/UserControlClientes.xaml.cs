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
    /// Interação lógica para UserControlClientes.xam
    /// </summary>
    public partial class UserControlClientes : UserControl
    {
        public UserControlClientes()
        {
            InitializeComponent();
        }

        Cliente cli = new Cliente();
        AutomoveisEntities db;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cli.CodCliente = int.Parse(txtID.Text);
            cli.Nome = txtNome.Text;
            cli.Email = txtEmail.Text;
            cli.Telefone = txtTelefone.Text;

            db.Cliente.Add(cli);
            db.SaveChanges();
            MyDataGrid.ItemsSource = db.Cliente.ToList();

            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtID.Text);
            var cli = db.Cliente.Where(c => c.CodCliente == num).FirstOrDefault();
            cli.Nome = txtNome.Text;
            cli.Email = txtEmail.Text;
            cli.Telefone = txtTelefone.Text;

            db.SaveChanges();
            MyDataGrid.ItemsSource = db.Cliente.ToList();

            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }

        private void MyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            db = new AutomoveisEntities();
            MyDataGrid.ItemsSource = db.Cliente.ToList();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtID.Text);
            var cli = db.Cliente.Where(c => c.CodCliente == num).FirstOrDefault();
            db.Cliente.Remove(cli);
            db.SaveChanges();

            MyDataGrid.ItemsSource = db.Cliente.ToList();

            txtID.Clear();
        }
    }
}
