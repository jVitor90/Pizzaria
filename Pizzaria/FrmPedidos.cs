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
        Model.Mesas_lancamentos itemnsComanda = new Model.Mesas_lancamentos();
        Model.OrdensComandas ordens = new Model.OrdensComandas();
       
        public void AtualizarDgvPedidos()
        {
         
        
            dgvPedidos.DataSource = ordens.ListarComanda();

        }

        


        private void brnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show(
               $"Tem certeza que deseja encerrar a comanda {ordens.num_mesa}?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pergunta == DialogResult.Yes)
            {
                if (ordens.Encerrar())
                {
                    MessageBox.Show("Comanda Encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                }

                AtualizarDgvPedidos();

            }
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvPedidos.SelectedCells[0].RowIndex;

            
        }
    }
}

