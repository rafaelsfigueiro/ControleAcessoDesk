namespace ControleAcessoDesk.v2
{
    partial class ConsultaDeAcesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            txtnome = new DataGridViewTextBoxColumn();
            txtcpf = new DataGridViewTextBoxColumn();
            txttipo = new DataGridViewTextBoxColumn();
            txtsenha = new DataGridViewTextBoxColumn();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnVoltar = new Button();
            btnEditar = new Button();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 197);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 33;
            label4.Text = "Nivel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 168);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 32;
            label3.Text = "Cpf";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 131);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 31;
            label2.Text = "Nome";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtnome, txtcpf, txttipo, txtsenha });
            dataGridView1.Location = new Point(206, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(403, 132);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtnome
            // 
            txtnome.HeaderText = "NOME";
            txtnome.Name = "txtnome";
            // 
            // txtcpf
            // 
            txtcpf.HeaderText = "CPF";
            txtcpf.Name = "txtcpf";
            // 
            // txttipo
            // 
            txttipo.HeaderText = "TIPO";
            txttipo.Name = "txttipo";
            // 
            // txtsenha
            // 
            txtsenha.HeaderText = "SENHA";
            txtsenha.Name = "txtsenha";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(256, 160);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Administrador", "Funcionário", "Visitante" });
            comboBox2.Location = new Point(256, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 27;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(256, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 47);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 25;
            label1.Text = "Consulta de Acessos ";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(393, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(302, 377);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "&Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(206, 377);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "E&ditar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(393, 189);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 34;
            btnFiltrar.Text = "&Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // ConsultaDeAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFiltrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnVoltar);
            Controls.Add(btnEditar);
            Name = "ConsultaDeAcesso";
            Text = "ConsultaDeAcesso";
            Load += ConsultaDeAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnCancelar;
        private Button btnVoltar;
        private Button btnEditar;
        private Button btnFiltrar;
        private DataGridViewTextBoxColumn txtnome;
        private DataGridViewTextBoxColumn txtcpf;
        private DataGridViewTextBoxColumn txttipo;
        private DataGridViewTextBoxColumn txtsenha;
    }
}