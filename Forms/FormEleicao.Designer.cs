namespace SistemaEleicoesEstudantis.Forms
{
    partial class FormEleicao
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
            ptbFechar = new PictureBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            dtpFim = new DateTimePicker();
            label3 = new Label();
            dtpInicio = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnSalvar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            label2 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            dgvEleicoes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ptbFechar).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEleicoes).BeginInit();
            SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpFim);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 458);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS DA ELEIÇÃO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 282);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 14;
            label4.Text = "Estado";
            // 
            // dtpFim
            // 
            dtpFim.Location = new Point(33, 232);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(305, 27);
            dtpFim.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 209);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 12;
            label3.Text = "Data Fim";
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(33, 154);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(305, 27);
            dtpInicio.TabIndex = 11;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(33, 305);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(302, 28);
            cmbEstado.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 192, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(340, 394);
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
            btnAtualizar.Location = new Point(234, 394);
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
            btnExcluir.Location = new Point(127, 394);
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
            btnLimpar.Location = new Point(23, 394);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 131);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Data Início";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(33, 77);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(305, 27);
            txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 51);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Título";
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
            panel1.Size = new Size(1177, 543);
            panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvEleicoes);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(490, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(655, 354);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "DADOS INSERIDOS";
            // 
            // dgvEleicoes
            // 
            dgvEleicoes.AllowUserToOrderColumns = true;
            dgvEleicoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEleicoes.Location = new Point(3, 20);
            dgvEleicoes.Name = "dgvEleicoes";
            dgvEleicoes.RowHeadersWidth = 51;
            dgvEleicoes.Size = new Size(646, 328);
            dgvEleicoes.TabIndex = 0;
            dgvEleicoes.CellClick += dgvEleicoes_CellClick;
            // 
            // FormEleicao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 543);
            Controls.Add(panel1);
            Name = "FormEleicao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEleicao";
            Load += FormEleicao_Load;
            ((System.ComponentModel.ISupportInitialize)ptbFechar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEleicoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbFechar;
        private GroupBox groupBox1;
        private ComboBox cmbEstado;
        private Button btnSalvar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Label label2;
        private TextBox txtTitulo;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox2;
        private DataGridView dgvEleicoes;
        private Label label3;
        private DateTimePicker dtpInicio;
        private Label label4;
        private DateTimePicker dtpFim;
    }
}