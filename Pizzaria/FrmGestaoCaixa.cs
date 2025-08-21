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
        Model.OrdensComandas comandas = new Model.OrdensComandas();
        Model.Metodos_pagamento metodos = new Metodos_pagamento();
        Model.Itens_comandas itens = new Model.Itens_comandas();
        public FrmGestaoCaixa()
        {
            InitializeComponent();
            //Obter as categorias do banco
            AtualizarDgvCaixa();
            DataTable resultado = metodos.Listar();
            foreach(DataRow linha in resultado.Rows)
            {
                // Adiconar o combobox
                cmbFormaPagamento.Items.Add($"{linha["id_metodo"]} - {linha["nome_metodo"]}");
            }
        }
       

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show(
               $"Tem certeza que deseja encerrar a comanda {itens.situacao_pedido}?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pergunta == DialogResult.Yes)
            {
                if (itens.Encerrar())
                {
                    MessageBox.Show("Comanda Encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgvCaixa();

                }
        }   }   

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            
                if (txbMesa.Text == "" || txbMesa.Text.Length < 1)
                {
                    MessageBox.Show("Informe corretamente o número da ficha!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                
                    comandas.num_mesa = int.Parse(txbMesa.Text);
                    DataTable consulta = comandas.BuscarMesa();


                    //Verificar se existe lançamentos na comanda
                    if (consulta.Rows.Count == 0)
                    {
                        MessageBox.Show("Não existe lancamentos nessa comnada!",
                       "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Mostar a consulta no dgv
                        dgvComanda.DataSource = consulta;
                        AtualizarDgvCaixa();

                    //Mostrar no label o total:
                    decimal valorTotal = Convert.ToDecimal(consulta.Compute("SUM(Total_Item)", ""));
                    txbValor.Text = "R$ " + valorTotal.ToString("N2");
                }
                    grbInformacoes.Enabled = true;
                }
            

        }
        public void AtualizarDgvCaixa()
        {
            dgvComanda.DataSource = comandas.BuscarMesa();

        }



        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txbMesa.Clear();
            txbValor.Clear();
            cmbFormaPagamento.Text = " ";
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

        