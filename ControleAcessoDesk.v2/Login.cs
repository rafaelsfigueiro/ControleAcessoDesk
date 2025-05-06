using ControleAcesso.Desk;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtUsuario.Text, txtSenha.Text);
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {
                        CadastroDeUsuario cadastroDeUsuario = new CadastroDeUsuario();
                        cadastroDeUsuario.Show();
                        this.Hide();  //Fecha a forma atual

                        // login aceito
                        // código para registrar o usuario logado

                      
                    }
                    else
                    {
                        MessageBox.Show("Sua conta está inativa. " +
                            "\n Procure o administrador. ", $"olá {usuario.Nome}");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos ou inexistente!", "Login");
                }
            }
            else
            {
                MessageBox.Show("Os campos Usuario e senha são obrigatórios");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroDeUsuario cadastrar = new CadastroDeUsuario();
            cadastrar.Show();
            this.Hide();  //Fecha a forma atual
        }
    }
}
// teste git...