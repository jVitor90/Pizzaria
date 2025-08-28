using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
            AtualizarDgvPedidos();
        }
        Model.Usuario usuario = new Usuario();
        Model.Mesas_lancamentos itemnsComanda = new Model.Mesas_lancamentos();
        Model.Mesas mesas = new Model.Mesas();
        public void AtualizarDgvPedidos()
        {
            dgvPedidos.DataSource = mesas.ListarMesas();
        }

        private void brnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show(
            $"Tem certeza que deseja encerrar a comanda {mesas.num_mesa}?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pergunta == DialogResult.Yes)
            {
                if (mesas.Encerrar())
                {
                    MessageBox.Show("Comanda Encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AtualizarDgvPedidos();
            }
        }
        private int idLancamentoSelecionado = 0;
        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valorCelula = dgvPedidos.Rows[e.RowIndex].Cells[1].Value;

                if (valorCelula != DBNull.Value && valorCelula != null)
                {
                    mesas.num_mesa = Convert.ToInt32(valorCelula);
                }
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmOpcoes frmOpcoes = new FrmOpcoes(usuario);
            this.Hide();
            frmOpcoes.ShowDialog();
            this.Show();
        }
    }
}