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
                    return; // Interrompe o processo
                }
                if (mesas_Lancamentos.Encerrar())
                {
                    MessageBox.Show("Comanda Encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Atualizar();

                    dgvComanda.DataSource = "";
                    txbMesa.Clear();
                    lblValor.Text ="";
                    cmbFormaPagamento.Text = " ";

                    dgvComanda.DataSource = "";
                }
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txbMesa.Text == "" || txbMesa.Text.Length < 1)
            {
                MessageBox.Show("Informe corretamente o número da mesa!",
                       "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mesas_Lancamentos.num_mesa = int.Parse(txbMesa.Text);
                DataTable consulta = mesas_Lancamentos.Listar();
                txbMesa.Enabled = false;

                //Verificar se existe lançamentos na comanda
                if (consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe lançamentos nessa comnada!",
                   "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Mostar a consulta no dgv
                    dgvComanda.DataSource = consulta;
                    Atualizar();

                    //Mostrar no label o total:
                    lblValor.Text = "R$" + consulta.Compute("Sum(Total_Item)", "True").ToString();

                    grbPagamentos.Enabled = true;
                }
            }
        }
        public void Atualizar()
        {
            dgvComanda.DataSource = mesas_Lancamentos.Listar();
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
            FrmOpcoes frmOpcoes = new FrmOpcoes(usuario);
            this.Hide();
            frmOpcoes.ShowDialog();
            this.Show();
        }
    }
}