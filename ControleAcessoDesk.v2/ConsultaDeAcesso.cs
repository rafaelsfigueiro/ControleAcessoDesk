﻿using ControleAcesso.Desk;
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
    public partial class ConsultaDeAcesso : Form
    {
        public ConsultaDeAcesso()
        {
            InitializeComponent();
        }

        private void ConsultaDeAcesso_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            inicial inicial = new inicial();
            inicial.Show();
            this.Hide();  //Fecha a forma atual
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
