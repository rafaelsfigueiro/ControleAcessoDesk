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
    public partial class CadastroDeUsuario : Form
    {
        public CadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnEntrar.Text != string.Empty && btnEntrar.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(btnEntrar.Text, btnEntrar.Text);
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {
                        // login aceito
                        // código para registrar o usuario logado

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Sua conta está inativa. " +
                            "\n Procure o administrador. ", $"olá {usuario.Nome}");
                    }
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos ou inexistente!", "Login");
                }
            }
            else
            {
                MessageBox.Show("Os campos email e senha são obrigatórios");
            }
        }
    }
}
