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
    public partial class FrmGestaoCaixa : Form
    {
        Model.Usuario usuario = new Usuario();
        Model.Metodos_pagamento metodos = new Metodos_pagamento();
        Model.Mesas mesas = new Mesas();
        Model.Mesas_lancamentos mesas_Lancamentos = new Mesas_lancamentos();
        public FrmGestaoCaixa()
        {
            InitializeComponent();
            //Obter as categorias do banco
            //  AtualizarDgvCaixa();
            DataTable resultado = metodos.Listar();
            foreach (DataRow linha in resultado.Rows)
            {
                // Adiconar o combobox
                cmbFormaPagamento.Items.Add($"{linha["id_metodo"]} - {linha["nome_metodo"]}");
            }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {


            DialogResult pergunta = MessageBox.Show(
                $"Tem certeza que deseja encerrar a comanda {mesas_Lancamentos.num_mesa}?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pergunta == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(cmbFormaPagamento.Text))
                {
                    MessageBox.Show("Selecione uma forma de pagamento antes de encerrar a comanda!",
                                   "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbFormaPagamento.Focus();
                    return;
                }

                if (mesas_Lancamentos.Encerrar())
                {
                    // Marcar a mesa como inativa
                    mesas.num_mesa = mesas_Lancamentos.num_mesa;
                    mesas.Encerrar();

                    MessageBox.Show("Comanda Encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Atualizar();

                    dgvComanda.DataSource = null;
                    txbMesa.Clear();
                    lblValor.Text = "";
                    cmbFormaPagamento.Text = "";
                    grbPagamentos.Enabled = false;
                    txbMesa.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao encerrar a comanda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbMesa.Text, out int numeroMesa))
            {
                MessageBox.Show("Informe corretamente o número da mesa!",
                       "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mesas_Lancamentos.num_mesa = numeroMesa;
            DataTable consulta = mesas_Lancamentos.Listar();

            if (consulta == null)
            {
                MessageBox.Show("Erro ao consultar a comanda no banco de dados!",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (consulta.Rows.Count == 0)
            {
                MessageBox.Show("Não existe lançamentos nessa comanda!",
                   "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar os itens no DataGridView
            dgvComanda.DataSource = consulta;

            try
            {
                // Verifica se existe a coluna "Total_Item"
                if (consulta.Columns.Contains("Total_Item"))
                {
                    lblValor.Text = "R$ " + consulta.Compute("Sum(Total_Item)", string.Empty).ToString();
                }
                else
                {
                    lblValor.Text = "Total não disponível";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o total: " + ex.Message,
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            grbPagamentos.Enabled = true;
            txbMesa.Enabled = false;
        }
    


        public void Atualizar()
        {
           
        
            DataTable consulta = mesas_Lancamentos.ListarProdutos(); // Usar ListarProdutos em vez de Listar

            
        
        }
        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txbMesa.Clear();
            lblValor.Text = "";
            cmbFormaPagamento.Text = " ";

            dgvComanda.DataSource = "";
            grbPagamentos.Enabled = false;
            txbMesa.Enabled = true;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}