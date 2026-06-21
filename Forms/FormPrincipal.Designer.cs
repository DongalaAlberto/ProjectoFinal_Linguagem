namespace SistemaEleicoesEstudantis
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            novoToolStripMenuItem = new ToolStripMenuItem();
            eleitoresToolStripMenuItem = new ToolStripMenuItem();
            candidaturasToolStripMenuItem = new ToolStripMenuItem();
            eleiçõesToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            votaçãoToolStripMenuItem = new ToolStripMenuItem();
            resultadosToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            eleitoresToolStripMenuItem1 = new ToolStripMenuItem();
            candidaturasToolStripMenuItem1 = new ToolStripMenuItem();
            eleiçõesToolStripMenuItem1 = new ToolStripMenuItem();
            votaçãoToolStripMenuItem1 = new ToolStripMenuItem();
            resultadosToolStripMenuItem1 = new ToolStripMenuItem();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            imprimirRelatórioToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeCandidaturasToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVotosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeResultadosToolStripMenuItem = new ToolStripMenuItem();
            relatórioGeralToolStripMenuItem = new ToolStripMenuItem();
            sobreNósToolStripMenuItem = new ToolStripMenuItem();
            sobreNósToolStripMenuItem1 = new ToolStripMenuItem();
            logsDoSistemaToolStripMenuItem = new ToolStripMenuItem();
            painelPrincipal = new Panel();
            label2 = new Label();
            pnNomeEsp = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            painelPrincipal.SuspendLayout();
            pnNomeEsp.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { novoToolStripMenuItem, verToolStripMenuItem, editarToolStripMenuItem, manutençãoToolStripMenuItem, sobreNósToolStripMenuItem, logsDoSistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1924, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 192);
            novoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eleitoresToolStripMenuItem, candidaturasToolStripMenuItem, eleiçõesToolStripMenuItem });
            novoToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            novoToolStripMenuItem.ForeColor = Color.White;
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(138, 31);
            novoToolStripMenuItem.Text = "Cadastros";
            // 
            // eleitoresToolStripMenuItem
            // 
            eleitoresToolStripMenuItem.Name = "eleitoresToolStripMenuItem";
            eleitoresToolStripMenuItem.Size = new Size(249, 32);
            eleitoresToolStripMenuItem.Text = "Eleitores";
            eleitoresToolStripMenuItem.Click += eleitoresToolStripMenuItem_Click;
            // 
            // candidaturasToolStripMenuItem
            // 
            candidaturasToolStripMenuItem.Name = "candidaturasToolStripMenuItem";
            candidaturasToolStripMenuItem.Size = new Size(249, 32);
            candidaturasToolStripMenuItem.Text = "Candidaturas";
            candidaturasToolStripMenuItem.Click += candidaturasToolStripMenuItem_Click;
            // 
            // eleiçõesToolStripMenuItem
            // 
            eleiçõesToolStripMenuItem.Name = "eleiçõesToolStripMenuItem";
            eleiçõesToolStripMenuItem.Size = new Size(249, 32);
            eleiçõesToolStripMenuItem.Text = "Eleições";
            eleiçõesToolStripMenuItem.Click += eleiçõesToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 192);
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { votaçãoToolStripMenuItem, resultadosToolStripMenuItem });
            verToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            verToolStripMenuItem.ForeColor = Color.White;
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(136, 31);
            verToolStripMenuItem.Text = "Processos";
            // 
            // votaçãoToolStripMenuItem
            // 
            votaçãoToolStripMenuItem.Name = "votaçãoToolStripMenuItem";
            votaçãoToolStripMenuItem.Size = new Size(218, 32);
            votaçãoToolStripMenuItem.Text = "Votação";
            votaçãoToolStripMenuItem.Click += votaçãoToolStripMenuItem_Click;
            // 
            // resultadosToolStripMenuItem
            // 
            resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            resultadosToolStripMenuItem.Size = new Size(218, 32);
            resultadosToolStripMenuItem.Text = "Resultados";
            resultadosToolStripMenuItem.Click += resultadosToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 192);
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eleitoresToolStripMenuItem1, candidaturasToolStripMenuItem1, eleiçõesToolStripMenuItem1, votaçãoToolStripMenuItem1, resultadosToolStripMenuItem1 });
            editarToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            editarToolStripMenuItem.ForeColor = Color.White;
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(170, 31);
            editarToolStripMenuItem.Text = "Visualização";
            // 
            // eleitoresToolStripMenuItem1
            // 
            eleitoresToolStripMenuItem1.Name = "eleitoresToolStripMenuItem1";
            eleitoresToolStripMenuItem1.Size = new Size(249, 32);
            eleitoresToolStripMenuItem1.Text = "Eleitores";
            eleitoresToolStripMenuItem1.Click += eleitoresToolStripMenuItem1_Click;
            // 
            // candidaturasToolStripMenuItem1
            // 
            candidaturasToolStripMenuItem1.Name = "candidaturasToolStripMenuItem1";
            candidaturasToolStripMenuItem1.Size = new Size(249, 32);
            candidaturasToolStripMenuItem1.Text = "Candidaturas";
            candidaturasToolStripMenuItem1.Click += candidaturasToolStripMenuItem1_Click;
            // 
            // eleiçõesToolStripMenuItem1
            // 
            eleiçõesToolStripMenuItem1.Name = "eleiçõesToolStripMenuItem1";
            eleiçõesToolStripMenuItem1.Size = new Size(249, 32);
            eleiçõesToolStripMenuItem1.Text = "Eleições";
            eleiçõesToolStripMenuItem1.Click += eleiçõesToolStripMenuItem1_Click;
            // 
            // votaçãoToolStripMenuItem1
            // 
            votaçãoToolStripMenuItem1.Name = "votaçãoToolStripMenuItem1";
            votaçãoToolStripMenuItem1.Size = new Size(249, 32);
            votaçãoToolStripMenuItem1.Text = "Votação";
            // 
            // resultadosToolStripMenuItem1
            // 
            resultadosToolStripMenuItem1.Name = "resultadosToolStripMenuItem1";
            resultadosToolStripMenuItem1.Size = new Size(249, 32);
            resultadosToolStripMenuItem1.Text = "Resultados";
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 192);
            manutençãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imprimirRelatórioToolStripMenuItem, relatórioDeCandidaturasToolStripMenuItem, relatórioDeVotosToolStripMenuItem, relatórioDeResultadosToolStripMenuItem, relatórioGeralToolStripMenuItem });
            manutençãoToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            manutençãoToolStripMenuItem.ForeColor = Color.White;
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(135, 31);
            manutençãoToolStripMenuItem.Text = "Relatórios";
            // 
            // imprimirRelatórioToolStripMenuItem
            // 
            imprimirRelatórioToolStripMenuItem.Name = "imprimirRelatórioToolStripMenuItem";
            imprimirRelatórioToolStripMenuItem.Size = new Size(390, 32);
            imprimirRelatórioToolStripMenuItem.Text = "Relatório de Eleitores";
            imprimirRelatórioToolStripMenuItem.Click += imprimirRelatórioToolStripMenuItem_Click;
            // 
            // relatórioDeCandidaturasToolStripMenuItem
            // 
            relatórioDeCandidaturasToolStripMenuItem.Name = "relatórioDeCandidaturasToolStripMenuItem";
            relatórioDeCandidaturasToolStripMenuItem.Size = new Size(390, 32);
            relatórioDeCandidaturasToolStripMenuItem.Text = "Relatório de Candidaturas";
            // 
            // relatórioDeVotosToolStripMenuItem
            // 
            relatórioDeVotosToolStripMenuItem.Name = "relatórioDeVotosToolStripMenuItem";
            relatórioDeVotosToolStripMenuItem.Size = new Size(390, 32);
            relatórioDeVotosToolStripMenuItem.Text = "Relatório de Votos";
            // 
            // relatórioDeResultadosToolStripMenuItem
            // 
            relatórioDeResultadosToolStripMenuItem.Name = "relatórioDeResultadosToolStripMenuItem";
            relatórioDeResultadosToolStripMenuItem.Size = new Size(390, 32);
            relatórioDeResultadosToolStripMenuItem.Text = "Relatório de Resultados";
            // 
            // relatórioGeralToolStripMenuItem
            // 
            relatórioGeralToolStripMenuItem.Name = "relatórioGeralToolStripMenuItem";
            relatórioGeralToolStripMenuItem.Size = new Size(390, 32);
            relatórioGeralToolStripMenuItem.Text = "Relatório Geral";
            relatórioGeralToolStripMenuItem.Click += relatórioGeralToolStripMenuItem_Click;
            // 
            // sobreNósToolStripMenuItem
            // 
            sobreNósToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 192);
            sobreNósToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreNósToolStripMenuItem1 });
            sobreNósToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            sobreNósToolStripMenuItem.ForeColor = Color.White;
            sobreNósToolStripMenuItem.Name = "sobreNósToolStripMenuItem";
            sobreNósToolStripMenuItem.Size = new Size(93, 31);
            sobreNósToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreNósToolStripMenuItem1
            // 
            sobreNósToolStripMenuItem1.Name = "sobreNósToolStripMenuItem1";
            sobreNósToolStripMenuItem1.Size = new Size(210, 32);
            sobreNósToolStripMenuItem1.Text = "Sobre Nós";
            // 
            // logsDoSistemaToolStripMenuItem
            // 
            logsDoSistemaToolStripMenuItem.BackColor = Color.FromArgb(0, 192, 192);
            logsDoSistemaToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            logsDoSistemaToolStripMenuItem.ForeColor = Color.White;
            logsDoSistemaToolStripMenuItem.Name = "logsDoSistemaToolStripMenuItem";
            logsDoSistemaToolStripMenuItem.Size = new Size(228, 31);
            logsDoSistemaToolStripMenuItem.Text = "Fechar Aplicação";
            logsDoSistemaToolStripMenuItem.Click += logsDoSistemaToolStripMenuItem_Click;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Controls.Add(label2);
            painelPrincipal.Controls.Add(pnNomeEsp);
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.ForeColor = Color.White;
            painelPrincipal.Location = new Point(0, 37);
            painelPrincipal.Margin = new Padding(5, 4, 5, 4);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(1924, 909);
            painelPrincipal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 882);
            label2.Name = "label2";
            label2.Size = new Size(110, 27);
            label2.TabIndex = 1;
            label2.Text = "Dv    v1.0";
            // 
            // pnNomeEsp
            // 
            pnNomeEsp.BackColor = SystemColors.ActiveCaption;
            pnNomeEsp.Controls.Add(label1);
            pnNomeEsp.Location = new Point(303, 293);
            pnNomeEsp.Margin = new Padding(5, 4, 5, 4);
            pnNomeEsp.Name = "pnNomeEsp";
            pnNomeEsp.Size = new Size(1265, 169);
            pnNomeEsp.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(260, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(759, 40);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE GESTÃO DE ELEIÇÕES ESTUDANTIS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1924, 946);
            Controls.Add(painelPrincipal);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão de  Eleições Estudantis";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            painelPrincipal.ResumeLayout(false);
            painelPrincipal.PerformLayout();
            pnNomeEsp.ResumeLayout(false);
            pnNomeEsp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem sobreNósToolStripMenuItem;
        private Panel painelPrincipal;
        private Panel pnNomeEsp;
        private Label label1;
        private ToolStripMenuItem eleitoresToolStripMenuItem;
        private ToolStripMenuItem candidaturasToolStripMenuItem;
        private ToolStripMenuItem eleiçõesToolStripMenuItem;
        private ToolStripMenuItem votaçãoToolStripMenuItem;
        private ToolStripMenuItem resultadosToolStripMenuItem;
        private ToolStripMenuItem logsDoSistemaToolStripMenuItem;
        private ToolStripMenuItem eleitoresToolStripMenuItem1;
        private ToolStripMenuItem candidaturasToolStripMenuItem1;
        private ToolStripMenuItem eleiçõesToolStripMenuItem1;
        private ToolStripMenuItem votaçãoToolStripMenuItem1;
        private ToolStripMenuItem resultadosToolStripMenuItem1;
        private ToolStripMenuItem imprimirRelatórioToolStripMenuItem;
        private ToolStripMenuItem relatórioDeCandidaturasToolStripMenuItem;
        private ToolStripMenuItem relatórioDeVotosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeResultadosToolStripMenuItem;
        private ToolStripMenuItem relatórioGeralToolStripMenuItem;
        private ToolStripMenuItem sobreNósToolStripMenuItem1;
        private Label label2;
    }
}
