namespace SistemaEleicoesEstudantis.Forms
{
    partial class FormLogin
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
            panel1 = new Panel();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtUtilizador = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUtilizador);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 424);
            panel1.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(265, 316);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(106, 35);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(92, 275);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Inseri a senha";
            txtSenha.Size = new Size(279, 27);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUtilizador
            // 
            txtUtilizador.Location = new Point(92, 216);
            txtUtilizador.Name = "txtUtilizador";
            txtUtilizador.PlaceholderText = "Inseri usuário";
            txtUtilizador.Size = new Size(279, 27);
            txtUtilizador.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(92, 252);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 3;
            label3.Text = "Palavra Passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 193);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 2;
            label2.Text = "Utilizador";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(140, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 90);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(92, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 38);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 8);
            label1.Name = "label1";
            label1.Size = new Size(235, 23);
            label1.TabIndex = 0;
            label1.Text = "CONTROLO DE ACESSO";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 424);
            Controls.Add(panel1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtUtilizador;
        private Button btnEntrar;
    }
}