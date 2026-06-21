namespace SistemaEleicoesEstudantis.Forms
{
    partial class FormVotacao
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
            dgvVotos = new DataGridView();
            ptbFechar = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            cmbEleitor = new ComboBox();
            cmbCandidatura = new ComboBox();
            btnVotar = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVotos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbFechar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(dgvVotos);
            panel1.Controls.Add(ptbFechar);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 460);
            panel1.TabIndex = 2;
            // 
            // dgvVotos
            // 
            dgvVotos.AllowUserToOrderColumns = true;
            dgvVotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVotos.Location = new Point(425, 67);
            dgvVotos.Name = "dgvVotos";
            dgvVotos.RowHeadersWidth = 51;
            dgvVotos.Size = new Size(720, 333);
            dgvVotos.TabIndex = 1;
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
            groupBox2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(425, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(720, 354);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "DADOS INSERIDOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbEleitor);
            groupBox1.Controls.Add(cmbCandidatura);
            groupBox1.Controls.Add(btnVotar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 354);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DADOS DE VOTAÇÃO";
            // 
            // cmbEleitor
            // 
            cmbEleitor.FormattingEnabled = true;
            cmbEleitor.Location = new Point(33, 73);
            cmbEleitor.Name = "cmbEleitor";
            cmbEleitor.Size = new Size(302, 27);
            cmbEleitor.TabIndex = 12;
            // 
            // cmbCandidatura
            // 
            cmbCandidatura.FormattingEnabled = true;
            cmbCandidatura.Location = new Point(36, 161);
            cmbCandidatura.Name = "cmbCandidatura";
            cmbCandidatura.Size = new Size(302, 27);
            cmbCandidatura.TabIndex = 10;
            // 
            // btnVotar
            // 
            btnVotar.BackColor = Color.FromArgb(0, 192, 0);
            btnVotar.Location = new Point(241, 213);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(94, 29);
            btnVotar.TabIndex = 9;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = false;
            btnVotar.Click += btnVotar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 138);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 2;
            label2.Text = "Candidatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 51);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 0;
            label1.Text = "Eleitor";
            // 
            // FormVotacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 460);
            Controls.Add(panel1);
            Name = "FormVotacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVotacao";
            Load += FormVotacao_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVotos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbFechar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox ptbFechar;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private CheckBox chkDocumentoValido;
        private ComboBox cmbCandidatura;
        private Button btnVotar;
        private Label label2;
        private Label label1;
        private DataGridView dgvVotos;
        private ComboBox cmbEleitor;
    }
}