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
    public partial class FormEleitor : Form
    {
        private int idSelecionado = 0;
        public FormEleitor()
        {
            InitializeComponent();
        }

        //Metodo Carregar Dados
        private void CarregarDados()
        {
            EleitorRepository repo = new EleitorRepository();

            dgvEleitores.DataSource = repo.Listar();
        }

        private void FormEleitor_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        //Metodo Limpar Campos
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtMatricula.Clear();

            idSelecionado = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Eleitor eleitor = new Eleitor();

            eleitor.Nome = txtNome.Text;
            eleitor.Email = txtEmail.Text;
            eleitor.Matricula = txtMatricula.Text;
            eleitor.Votou = false;

            EleitorRepository repo = new EleitorRepository();

            repo.Inserir(eleitor);

            CarregarDados();

            LimparCampos();

            MessageBox.Show("Eleitor registado com sucesso!");
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Eleitor eleitor = new Eleitor();

            eleitor.Id = idSelecionado;
            eleitor.Nome = txtNome.Text;
            eleitor.Email = txtEmail.Text;
            eleitor.Matricula = txtMatricula.Text;

            EleitorRepository repo =
                new EleitorRepository();

            repo.Atualizar(eleitor);

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

            EleitorRepository repo = new EleitorRepository();

            repo.Eliminar(idSelecionado);

            CarregarDados();

            LimparCampos();

            MessageBox.Show("Eliminado");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvEleitores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvEleitores.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);

                txtNome.Text = linha.Cells["Nome"].Value.ToString();

                txtEmail.Text = linha.Cells["Email"].Value.ToString();

                txtMatricula.Text = linha.Cells["Matricula"].Value.ToString();
            }
        }

        private void ptbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
