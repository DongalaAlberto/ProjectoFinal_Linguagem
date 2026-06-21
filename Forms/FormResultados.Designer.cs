namespace SistemaEleicoesEstudantis.Forms
{
    partial class FormResultados
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
            btnPublicarResultado = new Button();
            lblVencedor = new Label();
            btnFechar = new Button();
            btnAtualizar = new Button();
            groupBox1 = new GroupBox();
            dgvResultados = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(btnPublicarResultado);
            panel1.Controls.Add(lblVencedor);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 550);
            panel1.TabIndex = 2;
            // 
            // btnPublicarResultado
            // 
            btnPublicarResultado.BackColor = Color.FromArgb(0, 192, 0);
            btnPublicarResultado.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnPublicarResultado.ForeColor = Color.White;
            btnPublicarResultado.Location = new Point(691, 508);
            btnPublicarResultado.Name = "btnPublicarResultado";
            btnPublicarResultado.Size = new Size(170, 36);
            btnPublicarResultado.TabIndex = 6;
            btnPublicarResultado.Text = "Publicar Resultado";
            btnPublicarResultado.UseVisualStyleBackColor = false;
            btnPublicarResultado.Click += btnPublicarResultado_Click;
            // 
            // lblVencedor
            // 
            lblVencedor.AutoSize = true;
            lblVencedor.ForeColor = Color.White;
            lblVencedor.Location = new Point(834, 32);
            lblVencedor.Name = "lblVencedor";
            lblVencedor.Size = new Size(50, 20);
            lblVencedor.TabIndex = 5;
            lblVencedor.Text = "label1";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(192, 0, 0);
            btnFechar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(1018, 506);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(125, 38);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(192, 192, 0);
            btnAtualizar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(884, 506);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(117, 36);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvResultados);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1145, 451);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "RESULTADOS";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Dock = DockStyle.Fill;
            dgvResultados.Location = new Point(3, 23);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(1139, 425);
            dgvResultados.TabIndex = 0;
            // 
            // FormResultados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 550);
            Controls.Add(panel1);
            Name = "FormResultados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormResultados";
            Load += FormResultados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblVencedor;
        private Button btnFechar;
        private Button btnAtualizar;
        private GroupBox groupBox1;
        private DataGridView dgvResultados;
        private Button btnPublicarResultado;
    }
}