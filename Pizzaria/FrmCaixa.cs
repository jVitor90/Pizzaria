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
    public partial class FrmCaixa : Form
    {
        public FrmCaixa()
        {
            InitializeComponent();

        }
        Model.Itens_comandas itemnsComanda = new Model.Itens_comandas();
        Model.OrdensComandas ordens = new Model.OrdensComandas();
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txbPedido.Text == "" || txbPedido.Text.Length < 2)
            {
                MessageBox.Show("Informe corretamente o número da ficha!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ordens.id_comanda = int.Parse(txbPedido.Text);
                DataTable consulta = ordens.BuscarMesa();

                //Verificar se existe lançamentos na comanda
                if (consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe lancamentos nessa comnada!",
                   "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Mostar a consulta no dgv
                    dgvPedidos.DataSource = consulta;


                }
            }
        }
        public void AtualizarDgv()
        {
           
        }

        private void brnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show(
               $"Tem certeza que deseja encerrar a comanda {itemnsComanda.situacao_pedido}?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pergunta == DialogResult.Yes)
            {
                if (itemnsComanda.Encerrar())
                {
                    MessageBox.Show("Comanda Encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }
    }
}
