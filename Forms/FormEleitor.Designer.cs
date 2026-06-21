namespace SistemaEleicoesEstudantis.Forms
{
    partial class FormEleitor
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
            ptbFechar = new PictureBox();
            groupBox2 = new GroupBox();
            dgvEleitores = new DataGridView();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            txtMatricula = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbFechar).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEleitores).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(ptbFechar);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 418);
            panel1.TabIndex = 0;
            // 
            // ptbFechar
            // 
            ptbFechar.BackColor = Color.FromArgb(192, 0, 0);
            ptbFechar.Location = new Point(1113, 3);
            ptbFechar.Name = "ptbFechar";
            ptbFechar.Size = new Size(50, 37);
            ptbFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbFechar.TabIndex = 4;
            ptbFechar.TabStop = false;
            ptbFechar.Click += ptbFechar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvEleitores);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(490, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(655, 354);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "DADOS INSERIDOS";
            // 
            // dgvEleitores
            // 
            dgvEleitores.AllowUserToOrderColumns = true;
            dgvEleitores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEleitores.Location = new Point(3, 20);
            dgvEleitores.Name = "dgvEleitores";
            dgvEleitores.RowHeadersWidth = 51;
            dgvEleitores.Size = new Size(646, 328);
            dgvEleitores.TabIndex = 0;
            dgvEleitores.CellClick += dgvEleitores_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(txtMatricula);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 354);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "COLHETAS DE DADOS";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 192, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(340, 267);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(192, 192, 0);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(234, 267);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(192, 0, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(127, 267);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluír";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(0, 192, 192);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(23, 267);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(36, 201);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(302, 27);
            txtMatricula.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 175);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 4;
            label3.Text = "Matrícula";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(36, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 27);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 116);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(305, 27);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // FormEleitor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 418);
            Controls.Add(panel1);
            Name = "FormEleitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEleitor";
            Load += FormEleitor_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbFechar).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEleitores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private PictureBox ptbFechar;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtMatricula;
        private Label label3;
        private Button btnSalvar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dgvEleitores;
    }
}