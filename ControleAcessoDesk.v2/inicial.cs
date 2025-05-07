using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcessoDesk.v2
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroDeUsuario cadastroDeUsuario = new CadastroDeUsuario();
            cadastroDeUsuario.Show();
            this.Hide();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDeAcesso consultaDeAcesso = new ConsultaDeAcesso();
            consultaDeAcesso.Show();
            this.Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroDeAcesso registroDeAcesso = new RegistroDeAcesso();
            registroDeAcesso.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
