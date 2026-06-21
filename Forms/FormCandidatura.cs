using SistemaEleicoesEstudantis.Models;
using SistemaEleicoesEstudantis.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaEleicoesEstudantis.Forms
{
    public partial class FormCandidatura : Form
    {
        private int idSelecionado = 0;
        public FormCandidatura()
        {
            InitializeComponent();
        }

        //Metodo Carregar Eleições
        private void CarregarEleicoes()
        {
            EleicaoRepository repo = new EleicaoRepository();

            cmbEleicao.DataSource = repo.Listar();

            cmbEleicao.DisplayMember = "Titulo";

            cmbEleicao.ValueMember = "Id";
        }

        //Metodo Carregar dados
        private void CarregarDados()
        {
            CandidaturaRepository repo = new CandidaturaRepository();

            dgvCandidaturas.DataSource = repo.Listar();
        }

        //Metodo Limpar Campos
        private void LimparCampos()
        {
            txtNomeLista.Clear();

            chkDocumentoValido.Checked = false;

            if (cmbEleicao.Items.Count > 0)
            {
                cmbEleicao.SelectedIndex = 0;
            }

            idSelecionado = 0;
        }

        //Metodo
        private void FormCandidatura_Load(object sender, EventArgs e)
        {
            CarregarEleicoes();

            CarregarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeLista.Text == "")
            {
                MessageBox.Show("Informe o nome da lista");
                return;
            }
            else
            {
                Candidatura candidatura = new Candidatura();

                candidatura.NomeLista = txtNomeLista.Text;

                candidatura.DocumentoValido = chkDocumentoValido.Checked;

                candidatura.EleicaoId = Convert.ToInt32(cmbEleicao.SelectedValue);

                CandidaturaRepository repo = new CandidaturaRepository();

                repo.Inserir(candidatura);

                CarregarDados();

                MessageBox.Show("Candidatura registada");
            }
        }

        private void dgvCandidaturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id =
                    Convert.ToInt32(dgvCandidaturas.Rows[e.RowIndex].Cells["Id"].Value);

                CandidaturaRepository repo = new CandidaturaRepository();

                Candidatura candidatura = repo.BuscarPorId(id);

                if (candidatura != null)
                {
                    idSelecionado = candidatura.Id;

                    txtNomeLista.Text = candidatura.NomeLista;

                    chkDocumentoValido.Checked = candidatura.DocumentoValido;

                    cmbEleicao.SelectedValue = candidatura.EleicaoId;
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione uma candidatura");

                return;
            }

            Candidatura candidatura = new Candidatura();

            candidatura.Id = idSelecionado;

            candidatura.NomeLista = txtNomeLista.Text;

            candidatura.DocumentoValido = chkDocumentoValido.Checked;

            candidatura.EleicaoId = Convert.ToInt32(cmbEleicao.SelectedValue);

            CandidaturaRepository repo = new CandidaturaRepository();

            repo.Atualizar(candidatura);

            CarregarDados();

            LimparCampos();

            MessageBox.Show("Atualizado com sucesso");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione uma candidatura por favor!");

                return;
            }

            CandidaturaRepository repo = new CandidaturaRepository();

            repo.Eliminar(idSelecionado);

            CarregarDados();

            LimparCampos();

            MessageBox.Show("Eliminado com sucesso");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvCandidaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptbFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
