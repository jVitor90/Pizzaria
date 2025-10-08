using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            AtualizarDgvProdutos();
        }
        Model.Usuario usuario = new Usuario();
        Model.Mesas_lancamentos lancamentos = new Model.Mesas_lancamentos();
        Model.Mesas mesas = new Model.Mesas();
        
        public void AtualizarDgvProdutos()
        {
           
            dgvPedidos.DataSource =  mesas.ListarMesas();
            dgvProdutos.DataSource = lancamentos.Listar();


            dgvProdutos.Columns["id_Produto"].HeaderText = "ID Produto";
            if (dgvProdutos.Columns.Contains("nome_produto"))
                dgvProdutos.Columns["nome_produto"].HeaderText = "Produto";
            if (dgvProdutos.Columns.Contains("quantidade"))
                dgvProdutos.Columns["quantidade"].HeaderText = "Quantidade";
            if (dgvProdutos.Columns.Contains("nome_cliente"))
                dgvProdutos.Columns["nome_cliente"].HeaderText = "Nome do Cliente";

            if (dgvProdutos.Columns.Contains("id_lancamento"))
                dgvProdutos.Columns["id_lancamento"].Visible = false;
            if (dgvProdutos.Columns.Contains("num_mesa"))
                dgvProdutos.Columns["num_mesa"].Visible = false;
            if (dgvProdutos.Columns.Contains("preco"))
                dgvProdutos.Columns["preco"].Visible = false;
            if (dgvProdutos.Columns.Contains("total_item"))
                dgvProdutos.Columns["total_item"].Visible = false;

        }

        private void brnFinalizar_Click(object sender, EventArgs e)
        {
            if (mesas.num_mesa == 0)
            {
                MessageBox.Show("Selecione uma mesa antes de finalizar a comanda!",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult pergunta = MessageBox.Show(
                $"Tem certeza que deseja finalizar a comanda {mesas.num_mesa}?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pergunta == DialogResult.Yes)
            {
                if (mesas.Encerrar())
                {
                    MessageBox.Show("Comanda finalizada!",
                                   "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    dgvProdutos.DataSource = null;
                    dgvProdutos.Rows.Clear();
                    dgvProdutos.Refresh();

                   
                    dgvPedidos.DataSource = mesas.ListarMesas();
                    mesas.num_mesa = 0;
                }
                else
                {
                    MessageBox.Show("Erro ao finalizar a comanda ou não há lançamentos pendentes para essa mesa!",
                                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int idLancamentoSelecionado = 0;
        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.SelectedCells.Count == 0) return;

            int linhaSelecionada = dgvPedidos.SelectedCells[0].RowIndex;

            // Agora pega direto pelo nome da coluna (seguro contra mudanças de ordem)
            int numMesa = (int)dgvPedidos.Rows[linhaSelecionada].Cells["num_mesa"].Value;

            // Passa para as classes
            mesas.num_mesa = numMesa;
            lancamentos.num_mesa = numMesa;

           
            DataTable dados = lancamentos.ListarProdutos();

            if (dados.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado encontrado para a mesa selecionada.");
                return;
            }

            dgvProdutos.DataSource = dados;

            // Configurações das colunas if (DgvProdutos.Columns.Contains("id_Produto"))
            dgvProdutos.Columns["id_Produto"].HeaderText = "ID Produto";
            if (dgvProdutos.Columns.Contains("nome_produto"))
                dgvProdutos.Columns["nome_produto"].HeaderText = "Produto";
            if (dgvProdutos.Columns.Contains("quantidade"))
                dgvProdutos.Columns["quantidade"].HeaderText = "Quantidade";
            if (dgvProdutos.Columns.Contains("nome_cliente"))
                dgvProdutos.Columns["nome_cliente"].HeaderText = "Nome do Cliente";


            // Oculta colunas indesejadas
            if (dgvProdutos.Columns.Contains("id_lancamento"))
                dgvProdutos.Columns["id_lancamento"].Visible = false;
            if (dgvProdutos.Columns.Contains("num_mesa"))
                dgvProdutos.Columns["num_mesa"].Visible = false;
            if (dgvProdutos.Columns.Contains("preco"))
                dgvProdutos.Columns["preco"].Visible = false;
            if (dgvProdutos.Columns.Contains("total_item"))
                dgvProdutos.Columns["total_item"].Visible = false;

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