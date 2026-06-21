namespace SistemaEleicoesEstudantis.Forms
{
    partial class FormCandidatura
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
            dgvCandidaturas = new DataGridView();
            groupBox1 = new GroupBox();
            chkDocumentoValido = new CheckBox();
            cmbEleicao = new ComboBox();
            btnSalvar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            label2 = new Label();
            txtNomeLista = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbFechar).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidaturas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(ptbFechar);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 447);
            panel1.TabIndex = 1;
            // 
            // ptbFechar
            // 
            ptbFechar.BackColor = Color.FromArgb(192, 0, 0);
            ptbFechar.Location = new Point(1113, 6);
            ptbFechar.Name = "ptbFechar";
            ptbFechar.Size = new Size(50, 37);
            ptbFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbFechar.TabIndex = 4;
            ptbFechar.TabStop = false;
            ptbFechar.Click += ptbFechar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCandidaturas);
            groupBox2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(490, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(655, 354);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "DADOS INSERIDOS";
            // 
            // dgvCandidaturas
            // 
            dgvCandidaturas.BackgroundColor = Color.FromArgb(128, 128, 255);
            dgvCandidaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidaturas.Location = new Point(3, 20);
            dgvCandidaturas.Name = "dgvCandidaturas";
            dgvCandidaturas.RowHeadersWidth = 51;
            dgvCandidaturas.Size = new Size(646, 328);
            dgvCandidaturas.TabIndex = 0;
            dgvCandidaturas.CellClick += dgvCandidaturas_CellClick;
            dgvCandidaturas.CellContentClick += dgvCandidaturas_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkDocumentoValido);
            groupBox1.Controls.Add(cmbEleicao);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomeLista);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 354);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS DA CANDIDATURA";
            // 
            // chkDocumentoValido
            // 
            chkDocumentoValido.AutoSize = true;
            chkDocumentoValido.BackColor = Color.ForestGreen;
            chkDocumentoValido.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkDocumentoValido.ForeColor = Color.White;
            chkDocumentoValido.Location = new Point(36, 187);
            chkDocumentoValido.Name = "chkDocumentoValido";
            chkDocumentoValido.Size = new Size(198, 26);
            chkDocumentoValido.TabIndex = 11;
            chkDocumentoValido.Text = "Documento Válido";
            chkDocumentoValido.UseVisualStyleBackColor = false;
            // 
            // cmbEleicao
            // 
            cmbEleicao.FormattingEnabled = true;
            cmbEleicao.Location = new Point(36, 139);
            cmbEleicao.Name = "cmbEleicao";
            cmbEleicao.Size = new Size(302, 27);
            cmbEleicao.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 192, 0);
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
            btnLimpar.BackColor = Color.FromArgb(128, 128, 255);
            btnLimpar.Location = new Point(23, 267);
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
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 116);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 2;
            label2.Text = "Eleição";
            // 
            // txtNomeLista
            // 
            txtNomeLista.Location = new Point(33, 77);
            txtNomeLista.Name = "txtNomeLista";
            txtNomeLista.Size = new Size(305, 28);
            txtNomeLista.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 51);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome da Lista";
            // 
            // FormCandidatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 447);
            Controls.Add(panel1);
            Name = "FormCandidatura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCandidatura";
            Load += FormCandidatura_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbFechar).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCandidaturas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox ptbFechar;
        private GroupBox groupBox2;
        private DataGridView dgvCandidaturas;
        private GroupBox groupBox1;
        private ComboBox cmbEleicao;
        private Button btnSalvar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Label label2;
        private TextBox txtNomeLista;
        private Label label1;
        private CheckBox chkDocumentoValido;
    }
}