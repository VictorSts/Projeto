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

namespace Projeto
{
    /// <summary>
    /// Lógica interna para Contatos.xaml
    /// </summary>
    public partial class Contatos : Window
    {
        public Contatos()
        {
            InitializeComponent();
        }

        private void btnContatoEnviar_Click(object sender, RoutedEventArgs e)
        {     
            Contato contact = new Contato();

            contact.Nome = txtContatoNome.Text;
            contact.Email = txtContatoEmail.Text;
            contact.Telefone = txtContatoTelefone.Text;
            contact.Mensagem = txtContato.Text;

            using (AutomoveisEntities auto = new AutomoveisEntities())
            {
                auto.Contato.Add(contact);
                auto.SaveChanges();
            }
            MessageBox.Show("Sucesso");
            txtContatoNome.Clear();
            txtContatoEmail.Clear();
            txtContatoTelefone.Clear();

            /*try
            {
                aut.Contato.Add(contact);
                aut.SaveChanges();
                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning" );
            }*/
        }
    }
}
