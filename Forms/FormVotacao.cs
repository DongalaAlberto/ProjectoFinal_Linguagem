using SistemaEleicoesEstudantis.Exceptions;
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
    public partial class FormVotacao : Form
    {
        public FormVotacao()
        {
            InitializeComponent();
        }

        //Metodo Carregar Eleitores
        private void CarregarEleitores()
        {
            EleitorRepository repo = new EleitorRepository();

            cmbEleitor.DataSource = repo.Listar();

            cmbEleitor.DisplayMember = "Nome";

            cmbEleitor.ValueMember = "Id";
        }

        //Metodo Carregar Candidaturas
        private void CarregarCandidaturas()
        {
            CandidaturaRepository repo = new CandidaturaRepository();

            cmbCandidatura.DataSource = repo.ListarCombo();

            cmbCandidatura.DisplayMember = "NomeLista";

            cmbCandidatura.ValueMember = "Id";
        }

        //Metodo carregar votos
        private void CarregarVotos()
        {
            VotoRepository repo = new VotoRepository();

            dgvVotos.DataSource = repo.Listar();
        }

        private void FormVotacao_Load(object sender, EventArgs e)
        {
            CarregarEleitores();

            CarregarCandidaturas();

            CarregarVotos();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            try
            {
                int eleitorId = Convert.ToInt32(cmbEleitor.SelectedValue);

                EleitorRepository eleitorRepo = new EleitorRepository();

                Eleitor eleitor = eleitorRepo.BuscarPorId(eleitorId);

                if (eleitor.Votou)
                {
                    throw new VotoDuplicadoException();
                }

                Voto voto = new Voto();

                voto.DataHora = DateTime.Now;

                voto.EleitorId = eleitorId;

                voto.CandidaturaId = Convert.ToInt32(cmbCandidatura.SelectedValue);

                VotoRepository votoRepo = new VotoRepository();

                votoRepo.Inserir(voto);

                eleitorRepo.MarcarComoVotou(eleitorId);

                MessageBox.Show("Voto registado com sucesso!");

                CarregarVotos();
            }
            catch (VotoDuplicadoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void ptbFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
