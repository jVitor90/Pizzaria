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
        Model.Usuario Usuario;
        public FrmOpcoes(Model.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;

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
    }
}
