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
               $"Tem certeza que deseja encerrar a comanda {mesas.num_mesa}?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pergunta == DialogResult.Yes)
            {
                if (mesas.Encerrar())
                {
                    MessageBox.Show("Comanda Encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgvCaixa();

                }
        }   }   

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            
                if (txbMesa.Text == "" || txbMesa.Text.Length < 1)
                {
                    MessageBox.Show("Informe corretamente o número da mesa!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                
                    mesas.num_mesa = int.Parse(txbMesa.Text);
                    DataTable consulta = mesas.Listar();


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
                        AtualizarDgvCaixa();

                      //Mostrar no label o total:
                      //txbValor.Text = "R$" + consulta.Compute("Sum(Total_Item)", "True").ToString();

                      grbPagamentos.Enabled = true;
                }
                    
                }
            

        }
        public void AtualizarDgvCaixa()
        {
            //dgvComanda.DataSource = mesas.BuscarMesa();
            DataTable dt = mesas.Listar();
            dgvComanda.DataSource = dt;



            // Personalizar colunas
            if (dt.Rows.Count > 0)
            {
                //dgvComanda.Columns["id_mesa"].HeaderText = "ID Comanda";
                //dgvComanda.Columns["num_mesa"].HeaderText = "Nº Mesa";
                //dgvComanda.Columns["nome_cliente"].HeaderText = "Nome Cliente";
                //dgvComanda.Columns["Produto"].HeaderText = "Produto";
                //dgvComanda.Columns["Quantidade"].HeaderText = "Quantidade";
                //dgvComanda.Columns["Valor_Unit"].HeaderText = "Valor Unitario";
                //dgvComanda.Columns["Total_Item"].HeaderText = "Total";
                //dgvComanda.Columns["id_resp"].HeaderText = "ID Responsável";
                //if (dgvComanda.Columns.Contains("metodo_pagamento"))
                //{
                //    dgvComanda.Columns["metodo_pagamento"].HeaderText = "Método de Pagamento";
                //}
            }

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

        