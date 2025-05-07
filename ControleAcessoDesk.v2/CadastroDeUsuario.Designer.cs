namespace ControleAcessoDesk.v2
{
    partial class CadastroDeUsuario
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
            btnEntrar = new Button();
            cmbTipo = new ComboBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            txtSenha = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtCpf = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtId = new TextBox();
            label8 = new Label();
            boxAtivo = new CheckBox();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(471, 347);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 31;
            btnEntrar.Text = "E&ntrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Administrador", "Funcionário", "Visitante" });
            cmbTipo.Location = new Point(271, 189);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(220, 23);
            cmbTipo.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(534, 244);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 29;
            label6.Text = "&Foto (Opcional)";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(534, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(271, 221);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(234, 23);
            txtSenha.TabIndex = 27;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 224);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 26;
            label5.Text = "&Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(271, 22);
            label4.Name = "label4";
            label4.Size = new Size(252, 32);
            label4.TabIndex = 25;
            label4.Text = "Cadastro de Usuário ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 197);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 24;
            label3.Text = "&Tipo de usuário";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(271, 160);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(234, 23);
            txtCpf.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 163);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 22;
            label2.Text = "&CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 128);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 21;
            label1.Text = "&Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(271, 128);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(234, 23);
            txtNome.TabIndex = 20;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(378, 347);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "E&ditar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(271, 347);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Sa&lvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(271, 86);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 23);
            txtId.TabIndex = 36;
            txtId.UseSystemPasswordChar = true;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(168, 94);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 37;
            label8.Text = "Id";
            label8.Click += label8_Click;
            // 
            // boxAtivo
            // 
            boxAtivo.AutoSize = true;
            boxAtivo.Location = new Point(271, 262);
            boxAtivo.Name = "boxAtivo";
            boxAtivo.Size = new Size(54, 19);
            boxAtivo.TabIndex = 38;
            boxAtivo.Text = "&Ativo";
            boxAtivo.UseVisualStyleBackColor = true;
            boxAtivo.CheckedChanged += boxAtivo_CheckedChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(559, 347);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 39;
            btnVoltar.Text = "&Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // CadastroDeUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(boxAtivo);
            Controls.Add(label8);
            Controls.Add(txtId);
            Controls.Add(btnEntrar);
            Controls.Add(cmbTipo);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCpf);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Name = "CadastroDeUsuario";
            Text = "CadastroDeUsuario";
            Load += CadastroDeUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private ComboBox cmbTipo;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox txtSenha;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtCpf;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox txtId;
        private Label label8;
        private CheckBox boxAtivo;
        private Button btnVoltar;
    }
}