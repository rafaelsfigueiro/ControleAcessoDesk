namespace ControleAcessoDesk.v2
{
    partial class Login
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
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            btnCadastrar = new Button();
            btnAcessar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(324, 183);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(156, 23);
            txtSenha.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(324, 145);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(156, 23);
            txtUsuario.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(405, 232);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "&Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(324, 232);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 10;
            btnAcessar.Text = "&Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(275, 187);
            label3.Name = "label3";
            label3.Size = new Size(38, 13);
            label3.TabIndex = 9;
            label3.Text = "&Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(275, 149);
            label2.Name = "label2";
            label2.Size = new Size(43, 13);
            label2.TabIndex = 8;
            label2.Text = "&Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 79);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 7;
            label1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnCadastrar);
            Controls.Add(btnAcessar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Button btnCadastrar;
        private Button btnAcessar;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}