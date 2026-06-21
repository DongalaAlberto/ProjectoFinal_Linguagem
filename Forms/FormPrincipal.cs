using SistemaEleicoesEstudantis.Forms;
using SistemaEleicoesEstudantis.Vista;

namespace SistemaEleicoesEstudantis
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Metodo para abrir formulario
        private void AbrirFormulario(Form formulario)
        {
            painelPrincipal.Controls.Clear();

            formulario.TopLevel = false;

            formulario.FormBorderStyle = FormBorderStyle.None;

            formulario.Dock = DockStyle.Fill;

            painelPrincipal.Controls.Add(formulario);

            formulario.Show();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void eleitoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVistaEleitor frm = new FrmVistaEleitor();
            frm.ShowDialog();

            //AbrirFormulario(frm);
        }

        private void eleitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEleitor frm = new FormEleitor();
            frm.ShowDialog();
           

            //AbrirFormulario(frm);
        }

        private void eleiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEleicao frm2 = new FormEleicao();
            frm2.ShowDialog();
         
            //AbrirFormulario(frm2);
        }

        private void eleiçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVistaEleicao frm = new FrmVistaEleicao();
            frm.ShowDialog();
      

            //AbrirFormulario(frm);
        }

        //Abrir form da Candidatura
        private void candidaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCandidatura frm = new FormCandidatura();
            frm.ShowDialog();
           
            //AbrirFormulario(frm);
        }

        private void candidaturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVistaCandidatura frm = new FrmVistaCandidatura();
            frm.ShowDialog();
           
            //AbrirFormulario(frm);
        }

        private void logsDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Abrir form da Votação
        private void votaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVotacao form = new FormVotacao();
            form.ShowDialog();
  
            //AbrirFormulario(form);
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResultados frm = new FormResultados();
            frm.ShowDialog();
      

            //AbrirFormulario(frm);
        }

        //Em vez de estar assim deve ser assim "RelatóriodeEleitores"
        private void imprimirRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioEleitores frm = new FormRelatorioEleitores();
            frm.ShowDialog();
    
            //AbrirFormulario(frm);
        }

        //Abrir Relatório Geral
        private void relatórioGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioGeral frm = new FormRelatorioGeral();
            frm.ShowDialog();
        
            //AbrirFormulario(frm);
        }
    }
}
