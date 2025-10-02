using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class FrmFinanceiro : Form
    {
        Financeiro financeiro = new Financeiro();

        public FrmFinanceiro()
        {
            InitializeComponent();
           
        }

      
        private void atualizarFaturamento()
        {
           
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
         
            DateTime dataInicio = dtpInicio.Value;
            DateTime datafim = dtpFim.Value;

            financeiro.data_inicio = dataInicio;
            financeiro.data_fim = datafim;

            try
            {
                if (dtpInicio.Value > dtpFim.Value)
                {
                    MessageBox.Show("A data inicial não pode ser maior que a data final", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DataTable resultado = financeiro.ObterFaturamentoPeriodo();
                    if (resultado != null || resultado.Rows.Count > 0)
                    {
                        DgvFaturamento.DataSource = resultado;
                        DgvFaturamento.Columns["faturamento_total"].HeaderText = "Faturamento Total";
                        DgvFaturamento.Columns["faturamento_total"].DefaultCellStyle.Format = "C2";  // Formato moeda com 2 casas decimais
                    }
                    else
                    {
                        // Limpa o DataGridView se não houver resultados
                        DgvFaturamento.DataSource = null;
                        MessageBox.Show("Nenhum registro encontrado para o período selecionado.",
                                        "Sem Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar o faturamento: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void btnFaturamentoMensalAtual_Click(object sender, EventArgs e)
        {
            try
            {
                // Calcula o primeiro e último dia do mês atual automaticamente
                DateTime dataAtual = DateTime.Now;
                DateTime dataInicio = new DateTime(dataAtual.Year, dataAtual.Month, 1); // Primeiro dia do mês
                DateTime dataFim = dataInicio.AddMonths(1).AddDays(-1); // Último dia do mês

                // Instancia a classe Financeiro e define as datas
                Financeiro financeiro = new Financeiro();
                financeiro.data_inicio = dataInicio;
                financeiro.data_fim = dataFim;

                // Obtém o resultado do faturamento mensal
                DataTable resultado = financeiro.ObterFaturamentoMensalAtual();

                // Verifica se há dados antes de atribuir ao DataGridView
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    DgvFaturamento.DataSource = resultado;

                    // Garante que as colunas estejam disponíveis antes de formatar
                    DgvFaturamento.Refresh(); // Força a atualização da interface

                    // Formata a coluna de faturamento, se existir
                    if (DgvFaturamento.Columns.Contains("faturamento_mensal"))
                    {
                        DgvFaturamento.Columns["faturamento_mensal"].DefaultCellStyle.Format = "C2";
                        DgvFaturamento.Columns["faturamento_mensal"].HeaderText = "Faturamento Mensal";
                    }
                    if (DgvFaturamento.Columns.Contains("ano"))
                        DgvFaturamento.Columns["ano"].HeaderText = "Ano";
                    if (DgvFaturamento.Columns.Contains("mes"))
                        DgvFaturamento.Columns["mes"].HeaderText = "Mês";
                }
                else
                {
                    DgvFaturamento.DataSource = null;
                    MessageBox.Show("Nenhum registro encontrado para o mês atual.",
                                    "Sem Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar o faturamento: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRelatorioMensalGeral_Click(object sender, EventArgs e)
        {
            try
            {
                // Instancia a classe Financeiro
                Financeiro financeiro = new Financeiro();

                // Chama o método ObterFaturamentoTotalGeral
                DataTable resultado = financeiro.ObterFaturamentoMensal();

                // Exibe o resultado no DataGridView
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    DgvFaturamento.DataSource = resultado;
                    // Formata a coluna de faturamento como moeda
                    DgvFaturamento.Columns["faturamento_total_geral"].DefaultCellStyle.Format = "C2";  // Ajuste para o novo nome
                                                                                                       // Opcional: Define um cabeçalho personalizado
                    DgvFaturamento.Columns["faturamento_total_geral"].HeaderText = "Faturamento Total Geral";
                }
                else
                {
                    // Limpa o DataGridView se não houver resultados
                    DgvFaturamento.DataSource = null;
                    MessageBox.Show("Nenhum registro encontrado para o faturamento total.",
                                    "Sem Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar o faturamento: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    

            

      


   

