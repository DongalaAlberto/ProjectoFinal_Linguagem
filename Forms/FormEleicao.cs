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
    public partial class FormEleicao : Form
    {
        private int idSelecionado = 0;
        public FormEleicao()
        {
            InitializeComponent();
        }

        //Metodo Carregar Estados
        private void CarregarEstados()
        {
            cmbEstado.Items.Add("Aberta");
            cmbEstado.Items.Add("EmVotacao");
            cmbEstado.Items.Add("Encerrada");
            cmbEstado.Items.Add("Publicada");

            cmbEstado.SelectedIndex = 0;
        }

        //Metodo Carregar Dados
        private void CarregarDados()
        {
            EleicaoRepository repo = new EleicaoRepository();

            dgvEleicoes.DataSource = repo.Listar();
        }

        //Metodo LimparCampos
        private void LimparCampos()
        {
            txtTitulo.Clear();

            cmbEstado.SelectedIndex = 0;

            idSelecionado = 0;
        }

        private void FormEleicao_Load(object sender, EventArgs e)
        {
            CarregarEstados();

            CarregarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Eleicao eleicao = new Eleicao();

            eleicao.Titulo = txtTitulo.Text;
            eleicao.DataInicio = dtpInicio.Value;
            eleicao.DataFim = dtpFim.Value;
            eleicao.Estado = cmbEstado.Text;

            EleicaoRepository repo = new EleicaoRepository();

            repo.Inserir(eleicao);

            CarregarDados();

            LimparCampos();

            MessageBox.Show("Eleição registada");
        }

        private void dgvEleicoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvEleicoes.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);

                txtTitulo.Text = linha.Cells["Titulo"].Value.ToString();

                dtpInicio.Value = Convert.ToDateTime(linha.Cells["DataInicio"].Value);

                dtpFim.Value = Convert.ToDateTime(linha.Cells["DataFim"].Value);

                cmbEstado.Text = linha.Cells["Estado"].Value.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Eleicao eleicao = new Eleicao();

            eleicao.Id = idSelecionado;
            eleicao.Titulo = txtTitulo.Text;
            eleicao.DataInicio = dtpInicio.Value;
            eleicao.DataFim = dtpFim.Value;
            eleicao.Estado = cmbEstado.Text;

            EleicaoRepository repo = new EleicaoRepository();

            repo.Atualizar(eleicao);

            CarregarDados();

            LimparCampos();

            MessageBox.Show("Atualizado");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show(
                    "Selecione um registo");
                return;
            }

            EleicaoRepository repo = new EleicaoRepository();

            repo.Eliminar(idSelecionado);

            CarregarDados();

            LimparCampos();

            MessageBox.Show("Eliminado");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void ptbFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
