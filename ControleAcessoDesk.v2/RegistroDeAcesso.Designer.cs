namespace ControleAcessoDesk.v2
{
    partial class RegistroDeAcesso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker3 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            dgwRegistroAcesso = new DataGridView();
            clnMUsuario = new DataGridViewTextBoxColumn();
            clnSetor = new DataGridViewTextBoxColumn();
            clnEntrada = new DataGridViewTextBoxColumn();
            clnSainda = new DataGridViewTextBoxColumn();
            btnRetornar = new Button();
            btnAlterar = new Button();
            btnSalvar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwRegistroAcesso).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(534, 1);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(264, 23);
            dateTimePicker3.TabIndex = 33;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Funcionário", "Visitante" });
            comboBox1.Location = new Point(178, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 32;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 138);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 31;
            label5.Text = "Se&tor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 99);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 30;
            label4.Text = "&Usuario";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(178, 165);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 23);
            dateTimePicker2.TabIndex = 29;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(178, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 28;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 27;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dgwRegistroAcesso
            // 
            dgwRegistroAcesso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRegistroAcesso.Columns.AddRange(new DataGridViewColumn[] { clnMUsuario, clnSetor, clnEntrada, clnSainda });
            dgwRegistroAcesso.Location = new Point(104, 253);
            dgwRegistroAcesso.Name = "dgwRegistroAcesso";
            dgwRegistroAcesso.RowHeadersVisible = false;
            dgwRegistroAcesso.Size = new Size(573, 150);
            dgwRegistroAcesso.TabIndex = 26;
            dgwRegistroAcesso.CellContentClick += dgwRegistroAcesso_CellContentClick;
            // 
            // clnMUsuario
            // 
            clnMUsuario.HeaderText = "Usuario";
            clnMUsuario.Name = "clnMUsuario";
            clnMUsuario.Width = 150;
            // 
            // clnSetor
            // 
            clnSetor.HeaderText = "Setor";
            clnSetor.Name = "clnSetor";
            clnSetor.Width = 120;
            // 
            // clnEntrada
            // 
            clnEntrada.HeaderText = "Entrada";
            clnEntrada.Name = "clnEntrada";
            clnEntrada.Width = 150;
            // 
            // clnSainda
            // 
            clnSainda.HeaderText = "Saída";
            clnSainda.Name = "clnSainda";
            clnSainda.Width = 150;
            // 
            // btnRetornar
            // 
            btnRetornar.Location = new Point(455, 419);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(75, 23);
            btnRetornar.TabIndex = 25;
            btnRetornar.Text = "&Retornar";
            btnRetornar.UseVisualStyleBackColor = true;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(331, 419);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 24;
            btnAlterar.Text = "&Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(205, 419);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Sal&var";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 38);
            label3.Name = "label3";
            label3.Size = new Size(226, 32);
            label3.TabIndex = 22;
            label3.Text = "Registro de acesso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 211);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 21;
            label2.Text = "&Saida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 171);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 20;
            label1.Text = "&Entrada";
            // 
            // RegistroDeAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker3);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(dgwRegistroAcesso);
            Controls.Add(btnRetornar);
            Controls.Add(btnAlterar);
            Controls.Add(btnSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroDeAcesso";
            Text = "Form1";
            Load += RegistroDeAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dgwRegistroAcesso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private DataGridView dgwRegistroAcesso;
        private DataGridViewTextBoxColumn clnMUsuario;
        private DataGridViewTextBoxColumn clnSetor;
        private DataGridViewTextBoxColumn clnEntrada;
        private DataGridViewTextBoxColumn clnSainda;
        private Button btnRetornar;
        private Button btnAlterar;
        private Button btnSalvar;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
