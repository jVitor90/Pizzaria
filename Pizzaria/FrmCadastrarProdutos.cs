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
    public partial class FrmCadastrarProdutos : Form
    {
        public FrmCadastrarProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //validar Erros
            if(double.Parse(txbValor.Text) == 0.00)
            {
                MessageBox.Show("O preço e invalido", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbNomeProduto.Text.Length <= 3)
            {
                MessageBox.Show("O Nome informado é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoria.Text.Length <= 0)
            {
                MessageBox.Show("A categoria nao pode ser null cacacteres!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Iniciar o cadastro no Banco de dados
                Model.Produtos produtos = new Model.Produtos();
                produtos.nome_produto = txbNomeProduto.Text;
                produtos.preco = txbValor.Text;
            }
        }
    }
}
