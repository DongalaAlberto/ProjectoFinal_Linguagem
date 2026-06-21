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
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }

        //Metodo Carregar Resultado
        private void CarregarResultados()
        {
            VotoRepository repo = new VotoRepository();

            dgvResultados.DataSource = repo.ApurarResultados();
        }

        //Metodo Mostrar vencedor
        private void MostrarVencedor()
        {
            if (dgvResultados.Rows.Count > 0)
            {
                string vencedor = dgvResultados.Rows[0].Cells["NomeLista"].Value.ToString();

                string votos =
                    dgvResultados.Rows[0].Cells["TotalVotos"].Value.ToString();

                lblVencedor.Text = "Vencedor: " + vencedor + " (" + votos + " votos)";
            }
        }
        //
        private void FormResultados_Load(object sender, EventArgs e)
        {
            dgvResultados.ReadOnly = true;

            dgvResultados.AllowUserToAddRows = false;

            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CarregarResultados();

            MostrarVencedor();

            lblVencedor.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarResultados();

            MostrarVencedor();
        }

        private void btnPublicarResultado_Click(object sender, EventArgs e)
        {
            if (dgvResultados.Rows.Count == 0)
            {
                MessageBox.Show("Não existem resultados");
                return;
            }

            MessageBox.Show("Resultados publicados com sucesso!");
        }
    }
}
