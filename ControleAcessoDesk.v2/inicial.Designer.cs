namespace ControleAcessoDesk.v2
{
    partial class inicial
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
            btnCadastro = new Button();
            btnConsulta = new Button();
            btnRegistro = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(290, 63);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(167, 23);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "C&adastro de usuario";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(290, 106);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(167, 23);
            btnConsulta.TabIndex = 1;
            btnConsulta.Text = "&Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(290, 145);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(167, 23);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registro de acesso";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(290, 184);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnRegistro);
            Controls.Add(btnConsulta);
            Controls.Add(btnCadastro);
            Name = "inicial";
            Text = "inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastro;
        private Button btnConsulta;
        private Button btnRegistro;
        private Button btnLogin;
    }
}