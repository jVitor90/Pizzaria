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
    public partial class FrmOpcoes : Form
    {
        Model.Usuario usuario;
        public FrmOpcoes(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }

        private void FrmOpcoes_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarProdutos frmCadastrarProdutos = new FrmCadastrarProdutos();
            this.Hide();
            frmCadastrarProdutos.ShowDialog();
            this.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FrmGestaoCaixa frmGestaoCaixa = new FrmGestaoCaixa();
            this.Hide();
            frmGestaoCaixa.ShowDialog();
            this.Show();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            FrmGestaoComandas frmGestaoComanda = new FrmGestaoComandas(usuario);
            this.Hide();
            frmGestaoComanda.ShowDialog();
            this.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FrmGestaoEstoque frmGestaoEstoque = new FrmGestaoEstoque();
            this.Hide();
            frmGestaoEstoque.ShowDialog();
            this.Show();
        }

        private void bntpedidos_Click(object sender, EventArgs e)
        {
            FrmCaixa frmGestaoPedidos = new FrmCaixa();
            this.Hide();
            frmGestaoPedidos.ShowDialog(); this.Show();
            this.Show();
        }

        private void bntcadastrarusuarios_Click(object sender, EventArgs e)
        {
           // Adicionar
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Show();
        }
    }
}
